using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GW_Utility_V3
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            colorScheme.defautTheme();

            var materialSkinManager = colorScheme.globalInstance;
            materialSkinManager.AddFormToManage(this);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //Prompt the user for the location of the PaymentGateway

            /* Method Goes Here: LocateGateway() */
            await gatewayLoader.LocateGateway();

            //Assign Properties to labels
            label6.Text = gatewayProperties.Properties.InstalledLocation;
            label6.Visible = true;

            label7.Text = Convert.ToString(gatewayProperties.Properties.TotalTransactions);
            label7.Visible = true;

            label8.Text = "v" + gatewayProperties.Properties.InstalledVersion;
            label8.Visible = true;

            label9.Text = gatewayProperties.Properties.LatestTransaction;
            label9.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logForm Logs = new logForm();
            Logs.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            databaseForm database = new databaseForm();
            database.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settingForm SF = new settingForm();
            SF.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serviceForm service = new serviceForm();
            service.ShowDialog();
        }
    }
}
