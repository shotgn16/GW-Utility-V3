using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GW_Utility_V3
{
    public partial class serviceForm : MaterialForm
    {
        public serviceForm()
        {
            InitializeComponent();

            var materialSkinManager = colorScheme.globalInstance;
            materialSkinManager.AddFormToManage(this);
        }

        private async void startApp_btn_Click(object sender, EventArgs e)
        {
            await startupApp(startupArgument_tbx.Text, isAdmin_ckbox.Checked);
        }

        internal static async Task startupApp(string argument, bool runAdmin = false)
        {
            Process p = new Process();
            p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            p.StartInfo.FileName = gatewayProperties.Properties.InstalledLocation + "/PaymentGateway.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.RedirectStandardError = false;
            p.StartInfo.WorkingDirectory = gatewayProperties.Properties.InstalledLocation;
            if (!string.IsNullOrEmpty(argument)) { p.StartInfo.Arguments = argument; }
            if (runAdmin) { p.StartInfo.Verb = "runas"; }
            p.Start();
        }

        private void scheduleTask_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
