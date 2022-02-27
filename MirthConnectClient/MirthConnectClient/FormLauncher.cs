using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirthConnectClient
{
    public partial class FormLauncher : Form
    {
        public BindingList<MirthServerInfo> ServerInfoList { get; set; } = new();
        public FormLauncher()
        {
            InitializeComponent();
        }

        private void FormLauncher_Load(object sender, EventArgs e)
        {
            var textboxPassword = this.toolStripTextBoxPassword.Control as TextBox;
            textboxPassword.PasswordChar = '*';
            this.dataGridViewServerList.DataSource = this.ServerInfoList;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            var newEntry = new MirthServerInfo
            {
                MirthAdminUrl = this.toolStripTextBoxMirthAdminUrl.Text
                ,
                Login = this.toolStripTextBoxLogin.Text
                ,
                Password = this.toolStripTextBoxPassword.Text
            };
            this.ServerInfoList.Add(newEntry);

        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewServerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update");
                return;
            }
            var selectedItem = this.dataGridViewServerList.SelectedRows[0].DataBoundItem as MirthServerInfo;
            selectedItem.MirthAdminUrl = this.toolStripTextBoxMirthAdminUrl.Text;
            selectedItem.Login = this.toolStripTextBoxLogin.Text;
            selectedItem.Password = this.toolStripTextBoxPassword.Text;
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewServerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update");
                return;
            }
            var selectedIndex= this.dataGridViewServerList.SelectedRows[0].Index;
            var selectedItem = this.dataGridViewServerList.SelectedRows[0].DataBoundItem as MirthServerInfo;
            var dialogResult=MessageBox.Show(
                string.Format("Do you want to delete {0}@{1}",selectedItem.Login,selectedItem.MirthAdminUrl),
                "Confirm Deletion",
                MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;

            this.ServerInfoList.RemoveAt(selectedIndex);
        }

        private void toolStripButtonLaunch_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewServerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update");
                return;
            }
            var selectedItem = this.dataGridViewServerList.SelectedRows[0].DataBoundItem as MirthServerInfo;
            Uri uri = null;
            if (!Uri.TryCreate(selectedItem.MirthAdminUrl, UriKind.Absolute, out uri))
            {
                MessageBox.Show("Invalid Url specified");
                return;
            }
            using (FormMirthDashboard formMirthDashboard = new FormMirthDashboard())
            {
                formMirthDashboard.MirthServerInfo = selectedItem;
                formMirthDashboard.ShowDialog();
            }
        }

        private void dataGridViewServerList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                e.Value = "******";
            }
        }

        private void dataGridViewServerList_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewServerList.SelectedRows.Count == 0)
            {
                return;
            }
            var selectedItem = this.dataGridViewServerList.SelectedRows[0].DataBoundItem as MirthServerInfo;
            this.toolStripTextBoxMirthAdminUrl.Text=selectedItem.MirthAdminUrl ;
            this.toolStripTextBoxLogin.Text=selectedItem.Login;
            this.toolStripTextBoxPassword.Text=selectedItem.Password;
        }
    }
}
