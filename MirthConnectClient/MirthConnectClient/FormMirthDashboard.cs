using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using OpenapiGenerator.MirthConnect311.Api;
using OpenapiGenerator.MirthConnect311.Client;
using OpenapiGenerator.MirthConnect311.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirthConnectClient
{
    public partial class FormMirthDashboard : Form
    {
        public FormMirthDashboard()
        {
            InitializeComponent();
        }

        public MirthServerInfo MirthServerInfo { get; internal set; }
        public BindingList<MirthDashboardInfo> MirthDashboardInfoList { get; set; } = new();
        private void FormMirthDashboard_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            if (this.backgroundWorkerMirth.IsBusy) return;
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = "channellist.csv";
                sfd.DefaultExt = "csv";
                sfd.Filter = "CSV Files | *.csv";
                if (sfd.ShowDialog() != DialogResult.OK) return;
                using (var fs = sfd.OpenFile())
                using (var sw= new StreamWriter(fs))
                using (CsvHelper.CsvWriter cw = new CsvHelper.CsvWriter(sw,System.Globalization.CultureInfo.CurrentCulture)) 
                {
                    cw.WriteRecords(this.MirthDashboardInfoList);
                };
                if (MessageBox.Show("File saved, open now?","Save file complete",MessageBoxButtons.YesNo)!= DialogResult.Yes) return;
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = sfd.FileName,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
        }

        private void RefreshGrid()
        {
            if (this.backgroundWorkerMirth.IsBusy) return;
            MirthDashboardInfoList.Clear();
            dataGridView1.DataSource = MirthDashboardInfoList;
            backgroundWorkerMirth.RunWorkerAsync(this.MirthServerInfo);
        }

        private void backgroundWorkerMirth_DoWork(object sender, DoWorkEventArgs e)
        {
            var mirthServerInfo = e.Argument as MirthServerInfo;
            var client = new ApiClient(mirthServerInfo.MirthAdminUrl + "/api");
            client.SerializerSettings = new Newtonsoft.Json.JsonSerializerSettings
            {
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
               
               ,TypeNameHandling = TypeNameHandling.Objects
            };
            client.SerializerSettings.ContractResolver = new CustomContractResolver(client.SerializerSettings);
            var configuration = new Configuration();
            
            var userApi = new UsersApi(client, client, configuration);
            //userApi.Login(mirthServerInfo.Login, mirthServerInfo.Password);
            var localVarResponse =
                userApi.LoginWithHttpInfo(mirthServerInfo.Login, mirthServerInfo.Password);
            var loginStatus = localVarResponse.Data;            
            if (loginStatus.Status == null) throw new System.Security.SecurityException("error during login");
            var cookie = localVarResponse.Cookies.Where(c => c.Name == "JSESSIONID").First();
            if (cookie != null)
            {
                configuration.ApiKey.Add("JSESSIONID", cookie.Value);
            }
            switch (loginStatus.Status.Value)
            {
                case OpenapiGenerator.MirthConnect311.Model.LoginStatus.StatusEnum.SUCCESS:
                case OpenapiGenerator.MirthConnect311.Model.LoginStatus.StatusEnum.SUCCESSGRACEPERIOD:
                    break;
                default:
                    throw new System.Security.SecurityException("error during login");
            }
            var channelsApi = new ChannelsApi(client, client, configuration);
            var channelMapping = channelsApi.GetChannelIdsAndNames();
            MirthDashboardBackgroundWorkerProgress progress = new MirthDashboardBackgroundWorkerProgress();

            if (channelMapping != null)
            {
                var sortedchannelMapping = channelMapping.ToList().OrderBy(d => d.Value).ToList();
                int totalChannels = sortedchannelMapping.Count;
                progress.Max = totalChannels;
                int batchSize = 5;
                for (int currentProgress = 0; currentProgress < totalChannels; currentProgress += batchSize)
                {
                    var channelIdBatch = sortedchannelMapping.Skip(currentProgress)
                        .Take(batchSize).Select(c => c.Key).ToList();
                    List<MirthDashboardInfo> mirthDashboardInfoBatch = GetMirthDashboardInfo(client, channelsApi,
                        channelIdBatch,configuration, channelMapping);
                    progress.Progress = currentProgress;
                    progress.Message = string.Format("loading channel {0} of {1}", currentProgress, totalChannels);
                    progress.NewData = mirthDashboardInfoBatch;
                    backgroundWorkerMirth.ReportProgress(currentProgress, progress);
                }
                progress.Progress = totalChannels;
                progress.Message = string.Format("{0} channel loaded", totalChannels);
            }
            e.Result = progress;
        }

        private List<MirthDashboardInfo> GetMirthDashboardInfo(ApiClient client, ChannelsApi channelsApi,
            List<string> channelIdBatch, Configuration configuration, Dictionary<string, string> channelMapping)
        {
            var result = new Dictionary<string, MirthDashboardInfo>();
            var channels = channelsApi.GetChannels(channelIdBatch);
            if (channels == null) return result.Values.ToList();
            var channelStatusApi= new ChannelStatusOperationsApi(client, client, configuration);
            var messagesApi = new MessagesApi(client, client, configuration);
            foreach (var channel in channels)
            {
                var mirthDashboardInfo = new MirthDashboardInfo
                {
                    Id = channel.Id,
                    Description = channel.Description,
                    Name = channel.Name
                    ,Source= TranslateConnector(channel.SourceConnector, channelMapping)
                };
                StringBuilder sb = new StringBuilder();
                String seperator = "";
                if (channel.DestinationConnectors != null)
                {
                    foreach (var destinationConnector in channel.DestinationConnectors)
                    {
                        sb.Append(seperator);
                        sb.Append(TranslateConnector(destinationConnector, channelMapping));
                        seperator = ", ";
                    }
                }
                mirthDashboardInfo.Destinations = sb.ToString();
                result.Add(channel.Id, mirthDashboardInfo);                
            }
            var channelStatusList = channelStatusApi.GetChannelStatusList(channelIdBatch);
            if (channelStatusList != null)
            {
                foreach (var channelStatus in channelStatusList)
                {
                    var mirthDashboardInfo = result[channelStatus.ChannelId];
                    mirthDashboardInfo.QueuedMessages = channelStatus.Queued;
                    var messages = messagesApi.GetMessages(
                        channelStatus.ChannelId, null, null, null, null, null,
                        null, null, null, null, null, null, null, null, null
                        , null, null, null, null, null, null, null, null,
                        null, null, null, null, null, null, null, null,
                        null, null, null, null, null, null, true, 0, 1);
                    if (messages != null && messages.Count > 0)
                    {
                        mirthDashboardInfo.LastMessage = messages[0].ReceivedDate;
                    }
                }
            }
            
            return result.Values.OrderBy(c=>c.Name).ToList();           
        }

        private string TranslateConnector(OpenapiGenerator.MirthConnect311.Model.Connector connector, Dictionary<string, string> channelMapping)
        {
            StringBuilder sb = new StringBuilder();
            if (connector == null) return string.Empty;
            sb.Append(connector.TransportName);
            var connectionProperties = connector.Properties;
            if (connectionProperties == null) return sb.ToString();
            var jsonCOnnectorProperties = connectionProperties as JsonConnectorProperties;
            if (jsonCOnnectorProperties == null) return sb.ToString();
            var jo = JObject.Parse(jsonCOnnectorProperties.Json);
            var className=jo["@class"];
            if (className == null) return sb.ToString();
            switch ((string)className)
            {
                case "com.mirth.connect.connectors.tcp.TcpReceiverProperties":
                    var listenerConnectorProperties = jo["listenerConnectorProperties"];
                    if (listenerConnectorProperties != null)
                    {
                        var host = listenerConnectorProperties["host"];
                        var port = listenerConnectorProperties["port"];
                        if (host != null && port != null)
                        {
                            sb.AppendFormat(" {0}:{1}", (string)host, (string)port);
                        }
                    }  
                    break;
                case "com.mirth.connect.connectors.tcp.TcpDispatcherProperties":
                    var remoteHost = jo["remoteAddress"];
                    var remotePort = jo["remotePort"];
                    if (remoteHost != null && remotePort != null)
                    {
                        sb.AppendFormat(" {0}:{1}", (string)remoteHost, (string)remotePort);
                    }
                    break;
                case "com.mirth.connect.connectors.vm.VmDispatcherProperties":
                    var channelId = jo["channelId"];
                    if (channelId != null)
                    {
                        if(channelMapping.ContainsKey((string)channelId))
                            sb.AppendFormat(" to {0}", channelMapping[(string)channelId]);
                        else
                        {
                            sb.AppendFormat(" to {0}", (string)channelId);
                        }
                    }
                    break;
                 case  "com.mirth.connect.connectors.vm.VmReceiverProperties":
                    break;
                case "com.mirth.connect.connectors.file.FileReceiverProperties":
                    var path = jo["host"];
                    var fileFilter= jo["fileFilter"];
                    if (path != null && fileFilter != null)
                    {
                        sb.Append(string.Format(" {0}\\{1}", (string)path, (string)fileFilter));
                    }
                    break;
                case "com.mirth.connect.connectors.js.JavaScriptReceiverProperties":
                case "com.mirth.connect.connectors.js.JavaScriptDispatcherProperties":
                    sb.Append("Javascript");
                    break;
                case "com.mirth.connect.connectors.file.FileDispatcherProperties":
                    var scheme = jo["scheme"];
                    if (scheme != null)
                    {
                        var host = jo["host"];
                        var outputPattern = jo["outputPattern"];
                        switch ((string)scheme)
                        {
                            case "FILE":
                                if(host!=null && outputPattern!=null)
                                    sb.AppendLine(string.Format(":file://{0}/{1}",host, outputPattern));
                                break;
                            case "FTP":
                                if (host != null && outputPattern != null)
                                    sb.AppendLine(string.Format(":ftp://{0}/{1}",host, outputPattern));
                                break;
                            case "SFTP":
                                if (host != null && outputPattern != null)
                                    sb.AppendLine(string.Format(":sftp://{0}/{1}",host, outputPattern));
                                break;
                            default:
                                sb.Append(string.Format("Unknown scheme:{0}",
                                    (string)scheme));
                                break;
                        }
                    }
                    break;
                case "com.mirth.connect.connectors.jdbc.DatabaseDispatcherProperties":
                    break;
                default:
                    Debug.Assert(false);
                    break;

            }
           /* switch (connectionProperties.Class)
            {
                case "com.mirth.connect.connectors.file.FileDispatcherProperties":
                    switch (connectionProperties.Scheme)
                    {
                        case "File":
                            sb.AppendLine(string.Format(":file://{0}/{1}",
                                connectionProperties.Host
                             , connectionProperties.OutputPattern));
                            break;
                        case "FTP":
                            sb.AppendLine(string.Format(":ftp://{0}/{1}",
                                connectionProperties.Host
                             , connectionProperties.OutputPattern));
                            break;
                        case "SFTP":
                            sb.AppendLine(string.Format(":sftp://{0}/{1}",
                                connectionProperties.Host
                             , connectionProperties.OutputPattern));
                            break;
                        default:
                            sb.Append(string.Format("Unknown scheme:{0}",
                                connectionProperties.Scheme));
                            break;
                    }
                    break;
                case "com.mirth.connect.connectors.smtp.SmtpDispatcherProperties":
                    sb.Append(string.Format("from:{0} to:{1} subject {2} via {3}:{4})",
                        destinationPropertiesNode.SelectSingleNode("from").InnerText,
                        destinationPropertiesNode.SelectSingleNode("to").InnerText,
                        destinationPropertiesNode.SelectSingleNode("subject").InnerText,
                        destinationPropertiesNode.SelectSingleNode("smtpHost").InnerText,
                        destinationPropertiesNode.SelectSingleNode("smtpPort").InnerText));
                    sb.Append("SmtpDispatcher");
                    break;
                default:
                    sb.Append(string.Format("Unknown connector class:{0}",connectionProperties.Class));
                    break;
            }*/
            return sb.ToString();
        }

        private void backgroundWorkerMirth_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var progress = e.UserState as MirthDashboardBackgroundWorkerProgress;
            this.toolStripProgressBar1.Value = progress.Progress;
            this.toolStripProgressBar1.Maximum = progress.Max;
            this.toolStripStatusLabel1.Text = progress.Message;
            if (progress.NewData != null && progress.NewData.Count>0)
            {

                MirthDashboardInfoList.AddRange(progress.NewData);
            }
        }

        private void backgroundWorkerMirth_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            if (e.Error != null)
            {
                this.toolStripStatusLabel1.Text = e.Error.Message;
                return;
            }
            if (e.Result != null)
            {
                var progress = e.Result as MirthDashboardBackgroundWorkerProgress;
                this.toolStripProgressBar1.Value = progress.Progress;
                this.toolStripProgressBar1.Maximum = progress.Max;
                this.toolStripStatusLabel1.Text = progress.Message;
                return;
            }


        }
    }
}
