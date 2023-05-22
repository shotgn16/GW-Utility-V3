using GW_Utility_V3.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GW_Utility_V3
{
    internal class gatewayProperties
    {
        //Singleton class to make the properties publically accessable
        public static gatewayProperties Properties = new gatewayProperties();

        //Application Install location & Version
        internal string InstalledLocation { get; set; }

        [JsonProperty("appVersion")]
        internal string InstalledVersion { get; set; }
        internal string AppConfigLocation { get; set; }

        //Application properties - # Of Users, Transactions, Last Transaction
        internal int NumberOfUsers { get; set; }
        internal string LatestTransaction { get; set; }
        internal int TotalTransactions { get; set; }

        //Logger information - directory
        internal string LogDirectory { get; set; }

        //App database information - locatio and version
        internal string DatabaseLocation { get; set; }

        [JsonProperty("databaseVersion")]
        internal string DatabaseVersion { get; set; }

        [JsonProperty("databasePassword")]
        internal string DatabasePassword { get; set; }

        //Main app executable information - Location of PaymentGateway.exe
        internal string ExecutableDirectory { get; set; }
    }

    //Where can we get what information?

    //Install locations - Asking user for path to payment gateway
    //Number Of Users, LastTransaction - SQL Query (Database)
    //Versions, password - AppConfig (file)

    internal class gatewayLoader
    {
        internal static async Task<string> requestLocation(string location = null)
        {
            DialogResult result = MessageBox.Show("Please select the 'AppConfig.json' from the root directory of the ParentPay & MyQ Payment Gateway installiation", "Application Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            switch (result)
            {
                case DialogResult.Cancel:
                    Environment.Exit(0);
                    break;

                case DialogResult.OK:

                    using (var fileDialog = new OpenFileDialog())
                    {
                        fileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";

                        if (fileDialog.ShowDialog() == DialogResult.OK)
                            location = fileDialog.FileName;
                    }

                    break;
            }

            return location;
        }

        internal static async Task LocateGateway()
        {
            if (!string.IsNullOrEmpty(Settings1.Default.gatewayLocation))
            {
                gatewayProperties.Properties.AppConfigLocation = Settings1.Default.gatewayLocation + "AppConfig.json";   
            }

            else if (string.IsNullOrEmpty(Settings1.Default.gatewayLocation))
            {
                gatewayProperties.Properties.AppConfigLocation = await requestLocation();

                DialogResult dr = MessageBox.Show("Would you like to store this location for use in the future?", "Application Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (dr == DialogResult.Yes) 
                    Settings1.Default.gatewayLocation = gatewayProperties.Properties.AppConfigLocation.Replace("AppConfig.json", null);
                    Settings1.Default.Save();
            }

            string iLocation = gatewayProperties.Properties.AppConfigLocation.Replace("AppConfig.json", null);

            //Check if location is valid deserilisation/retrieve locatons of the rest of the data
            validate.ValidLocation();

            gatewayProperties.Properties.DatabaseLocation = iLocation + "db.sdf";
            gatewayProperties.Properties.InstalledLocation = iLocation;
            gatewayProperties.Properties.LogDirectory = iLocation + "logs";

            //Get information from the gateway database (After it has been locally replicated)
            await LoadSQL();
        }

        internal static async Task LoadSQL()
        {
            await database.CopyDatabase();
            gatewayProperties.Properties.NumberOfUsers = await database.getTotalUsers();
            gatewayProperties.Properties.LatestTransaction = await database.getLastestTransaction();
            gatewayProperties.Properties.TotalTransactions = await database.getTotalTransactions();
        }
    }

    internal class validate
    {
        //Will validate that the location given by the user is accurate by checking to see if the other files exist (database and exe). Then will attempt to read the AppConfig.json file and deserialise the response into the already existing JSON object 'gatewayProperties'
        internal static void ValidLocation()
        {
            string InstalLLocation = gatewayProperties.Properties.AppConfigLocation.Replace("AppConfig.json", null);

            if (File.Exists(InstalLLocation + "AppConfig.json") && File.Exists(InstalLLocation + "db.sdf"))
            {

                //Valid location!
                using (StreamReader sr = File.OpenText(gatewayProperties.Properties.AppConfigLocation))
                {
                    gatewayProperties.Properties = JsonConvert.DeserializeObject<gatewayProperties>(File.ReadAllText(gatewayProperties.Properties.AppConfigLocation));
                }
            }
            else
            {
                //Error
            }
        }
    }
}
