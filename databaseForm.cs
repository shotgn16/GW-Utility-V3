using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GW_Utility_V3
{
    public partial class databaseForm : MaterialForm
    {
        public databaseForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
        }

        private async void submitquery_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputquery_rtbx.Text))
            {
                string ValidQuery = await IsSqlQueryValid(inputquery_rtbx.Text);

                if (!string.IsNullOrEmpty(ValidQuery)) {
                    validsql_lbl.Visible = true;
                    validsql_lbl.ForeColor = Color.Red;
                    validsql_lbl.Text = "Error!" + ValidQuery;
                }

                else if (string.IsNullOrEmpty(ValidQuery))
                {
                    validsql_lbl.Visible = true;
                    validsql_lbl.ForeColor = Color.Green;
                    validsql_lbl.Text = "Valid SQL Syntax!";

                    DataTable dataTable = await database.userQuery(inputquery_rtbx.Text);

                    queryResults_DGV.ReadOnly = true;

                    if (dataTable is null)
                        { resulterror_lbl.ForeColor = Color.Red; 
                          resulterror_lbl.Visible = true;
                          resulterror_lbl.Text = "Error! An error occurred while processing your request, please try again..."; }

                    else if (dataTable != null)
                        queryResults_DGV.DataSource = dataTable;
                }
            }
                
        }

        private static async Task<string> IsSqlQueryValid(string SQL, List<string> error = null)
        {
            error = new List<string>();
            TSql140Parser parser = new TSql140Parser(false);
            TSqlFragment fragment;
            IList<ParseError> parseErrors;

            using (TextReader reader = new StringReader(SQL))
            {
                fragment = parser.Parse(reader, out parseErrors);
                if (parseErrors != null && parseErrors.Count > 0)
                {
                    error = parseErrors.Select(e => e.Message).ToList();

                    return error[0];
                }
            }

            return null;
        }

        private void databaseForm_Load(object sender, EventArgs e)
        {
            databaselocation_lbl.Text = "Database Location: " + gatewayProperties.Properties.DatabaseLocation;

            databaseversion_lbl.Text = "SQL Compact Version " + gatewayProperties.Properties.DatabaseVersion;
            databaseversion_lbl.BackColor = Color.Transparent;
            databaseversion_lbl.ForeColor = Color.White;
        }
    }
}
