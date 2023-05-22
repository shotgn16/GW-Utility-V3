using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GW_Utility_V3
{
    public partial class logForm : MaterialForm
    {
        public logForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
        }

        internal static string[] logFiles;
        internal static string filePath;

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = null;

            try
            {
                if (comboBox1.SelectedIndex != -1) 
                {
                    filePath = gatewayProperties.Properties.LogDirectory + "/" + comboBox1.Text;

                    foreach (string line in GetText(filePath))
                    {
                        richTextBox1.AppendText(line + Environment.NewLine);
                    }
                }

                richTextBox1.Text = File.ReadAllText(filePath);
            }

            catch (Exception ex)
            {
                //Error
            }
        }

        private static IEnumerable<string> GetText(string filePath)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    yield return line;
            }
        }

        private void logForm_Load(object sender, EventArgs e)
        {
            logdirectory_lbl.Text = "Log Directory: " + gatewayProperties.Properties.LogDirectory;
            
            //Populate the comboBox with a list of log files found in the 'logs' folder
            string[] logfiles = Directory.GetFiles(gatewayProperties.Properties.LogDirectory);

            foreach (string file in logfiles) {
                string fileName = Path.GetFileName(file);
                comboBox1.Items.Add(fileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                //Error - Please select a log file first!
            }

            List<string> parameters = new List<string>();

            if (!string.IsNullOrEmpty(LogLevel_tbx.Text)) {
                string i = LogLevel_tbx.Text;
                foreach (string par in LogLevel_tbx.Text.Split(','))
                {
                    parameters.Add(par);
                }
            }

            if (!string.IsNullOrEmpty(LogMessage_tbx.Text)) {
                string i = LogMessage_tbx.Text;
                foreach (string par in LogMessage_tbx.Text.Split(','))
                {
                    parameters.Add(par);
                }
            }

            if (!string.IsNullOrEmpty(LogTimestamp_tbx.Text)) {
                string i = LogTimestamp_tbx.Text;
                foreach (string par in LogTimestamp_tbx.Text.Split(','))
                {
                    parameters.Add(par);
                }
            }

            if (!string.IsNullOrEmpty(LogType_tbx.Text)) {
                string i = LogType_tbx.Text;
                foreach (string par in LogTimestamp_tbx.Text.Split(','))
                {
                    parameters.Add(par);
                }
            }

            richTextBox1.Text = null;

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string searchCriteria in parameters)
            {
                List<string> match = lines.Where(item => item.Contains(searchCriteria)).ToList();

                foreach (string item in match) 
                {
                    richTextBox1.AppendText(item + "\n");
                }
            }
        }

    }
}
