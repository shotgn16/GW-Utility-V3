using GW_Utility_V3.Properties;
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
    public partial class settingForm : MaterialForm
    {
        public settingForm()
        {
            InitializeComponent();

            var materialSkinManager = colorScheme.globalInstance;
            materialSkinManager.AddFormToManage(this);
        }

        private async void updateSettings_btn_Click(object sender, EventArgs e)
        {
            //If: item has been selected in combobox
            if (colourScheme_cbox.SelectedIndex != -1)
                await colorScheme.setColorScheme(colourScheme_cbox.Text);
        }

        private async void reset_btn_Click(object sender, EventArgs e)
        {
            Settings.Default.gatewayLocation = null;
            await gatewayLoader.LocateGateway();
        }
    }
}
