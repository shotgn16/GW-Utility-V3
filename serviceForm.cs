using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Win32.TaskScheduler;
using System.Windows.Forms;

namespace GW_Utility_V3
{
    public partial class serviceForm : MaterialForm
    {
        private static DailyTrigger dt;
        private static WeeklyTrigger wt;
        private static MonthlyTrigger mt;
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

        internal static async System.Threading.Tasks.Task startupApp(string argument, bool runAdmin = false)
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

        private async void schedulerHelp_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function will allow you and anybody who wishes to start the Payment Gateway, passing in arguments without having to navigate to the directory directly.\n\n The commands can be triggered directly from this window and will execute as if it was being run from the application directory", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void serviceForm_Load(object sender, EventArgs e)
        {
            fileLocation_lbl.Text = "File Location: " + gatewayProperties.Properties.InstalledLocation;
        }
    }
}
