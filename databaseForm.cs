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

            var materialSkinManager = colorScheme.globalInstance;
            materialSkinManager.AddFormToManage(this);
        }

        internal static string dbRequestError;

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

                    if (dataTable.Rows.Count == 0)
                        { resulterror_tbx.ForeColor = Color.Red;
                        resulterror_tbx.Visible = true;
                        resulterror_tbx.Text = "Error! " + dbRequestError; }

                    else if (dataTable.Rows.Count > 0)
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
            databaselocation_lbl.Text = "Database Location: " + gatewayProperties.Properties.DatabaseLocation + "\\db.sdf";
            databaselocation_lbl.LinkArea = new LinkArea(19, 100);

            databaseversion_lbl.Text = "SQL Compact Version " + gatewayProperties.Properties.DatabaseVersion;
            databaseversion_lbl.BackColor = Color.Transparent;
            databaseversion_lbl.ForeColor = Color.White;
        }

        private void databaselocation_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", gatewayProperties.Properties.DatabaseLocation);
        }
    }
}
