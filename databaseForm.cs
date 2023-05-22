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
    public partial class databaseForm : Form
    {
        public databaseForm()
        {
            InitializeComponent();
        }

        private async void submitquery_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputquery_rtbx.Text))
            {
                string error = await IsSqlQueryValid(inputquery_rtbx.Text);

                if (!string.IsNullOrEmpty(error))
                    error_lbl.Text = "Error!" + error;

                else if (string.IsNullOrEmpty(error))
                {
                    DataSet dataSet = await database.userQuery(inputquery_rtbx.Text);

                    queryResults_DGV.ReadOnly = true;

                    if (dataSet is null)
                        { /* Error */ }

                    else if (dataSet != null)
                        queryResults_DGV.DataSource = dataSet.Tables[0];
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
    }
}
