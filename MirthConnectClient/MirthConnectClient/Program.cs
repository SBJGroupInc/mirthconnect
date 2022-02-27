using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using OpenapiGenerator.MirthConnect311.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirthConnectClient
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new FormLauncher();
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.ServerList))
            {
                mainForm.ServerInfoList = new System.ComponentModel.BindingList<MirthServerInfo>();
            }
            else
            {
                try
                {
                    mainForm.ServerInfoList = System.Text.Json.JsonSerializer.Deserialize<System.ComponentModel.BindingList<MirthServerInfo>>(Properties.Settings.Default.ServerList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load server information, resetting");
                    mainForm.ServerInfoList = new System.ComponentModel.BindingList<MirthServerInfo>();
                }
                
            }
            System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            Application.Run(mainForm);
            Properties.Settings.Default.ServerList = System.Text.Json.JsonSerializer.Serialize(mainForm.ServerInfoList);
            Properties.Settings.Default.Save();

        }
    }
}
