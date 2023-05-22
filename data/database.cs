using GW_Utility_V3.Properties;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GW_Utility_V3
{
    internal class database
    {
        internal static ConnectionStringSettings connectionStringSettings { get; set; }

        internal static async Task<SqlCeConnection> ConnectAsync(SqlCeConnection conn = null)
        {
            try
            {
                if (File.Exists("db.sdf"))
                {
                    connectionStringSettings = new ConnectionStringSettings();
                    connectionStringSettings.ConnectionString = "DataSource=db.sdf;Password=" + await databaseHash.dbDecrypt(gatewayProperties.Properties.DatabasePassword, 5); ;

                    conn = new SqlCeConnection(connectionStringSettings.ConnectionString);
                }

                else
                {
                    await CopyDatabase();
                }
            }

            catch (Exception ex)
            {
                //Error
            }

            return conn;
        }

        internal static async Task<bool> CopyDatabase()
        {
            try
            {
                if (!File.Exists("db.sdf"))
                {
                    File.Copy(gatewayProperties.Properties.DatabaseLocation, AppDomain.CurrentDomain.BaseDirectory + "db.sdf");
                }

                else if (File.Exists("db.sdf"))
                {
                    var newTime = System.DateTime.Now + TimeSpan.FromMinutes(10);

                    //Every time this IF statement is run, it checks if the file was copied at lest 10 minutes ago. If it was, it will copy a new one, if not it will throw an error.
                    if (Settings1.Default.lastCopyTime >= newTime)
                    {
                        File.Delete("db.sdf");

                        File.Copy(gatewayProperties.Properties.DatabaseLocation, AppDomain.CurrentDomain.BaseDirectory + "db.sdf");

                        Settings1.Default.lastCopyTime = System.DateTime.Now;
                        Settings1.Default.Save();
                    }
                }
            }

            catch (Exception ex)
            {

            }
            return true;
        }

        internal static async Task<bool> CheckConnection(bool Valid = false)
        {
            using (var connection = await ConnectAsync())
            {
                try
                {
                    await connection.OpenAsync();
                    //Database connection: Opened successfully!

                    Valid = true;
                    //Database connection: Validated!

                    connection.Close();
                    //Database connection: Closed successfully!
                }

                catch (Exception ex)
                {
                    //Error
                }

                return Valid;
            }
        }

        //Get COUNT on return (Count = number of users in database)
        internal static async Task<int> getTotalUsers(int Count = 0)
        {
            try
            {
                using (var connection = await ConnectAsync())
                {
                    await connection.OpenAsync();

                    using (SqlCeCommand command = new SqlCeCommand("SELECT DISTINCT myqUserID FROM paymentupdates;", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                Count++;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                //Error
            }

            return Count;
        }

        internal static async Task<string> getLastestTransaction(string LatestTransaction = null)
        {
            try
            {
                using (var connection = await ConnectAsync())
                {
                    await connection.OpenAsync();

                    using (SqlCeCommand command = new SqlCeCommand("SELECT TOP 1 timeOfTransaction FROM paymentupdates ORDER BY timeOfTransaction DESC;", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                //Returns the time of the latest transaction stored in SQL - Converted to string
                                LatestTransaction = reader[0].ToString();
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                //Error
            }

            return LatestTransaction;
        }

        internal static async Task<int> getTotalTransactions(int transactions = 0)
        {
            try
            {
                using (var connection = await ConnectAsync())
                {
                    await connection.OpenAsync();

                    using (SqlCeCommand command = new SqlCeCommand("SELECT [myqUserID] FROM [paymentupdates]", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                transactions++;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                //Error
            }

            return transactions;
        }

        internal static async Task<DataTable> userQuery(string Query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                Query = await DecryptQuery(Query);

                using (var connection = await ConnectAsync())
                {
                    await connection.OpenAsync();

                    using (SqlCeCommand command = new SqlCeCommand(Query, connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                //Error
            }

            return dataTable;
        }

        internal static async Task<string> DecryptQuery(string Query)
        {
            if (Query.Contains("P_UserID "))
            {
                string item = Query.Remove(0, Query.IndexOf("P_UserID"));
                item = Regex.Match(item, @"\d+").Value;
                var item2 = await databaseHash.dbEncrypt(item, 1);
                Query = Query.Replace(item, item2);
            }

            if (Query.Contains("M_UserID"))
            {
                string item = Query.Remove(0, Query.IndexOf("M_UserID"));
                item = Regex.Match(item, @"\d+").Value;
                var item2 = await databaseHash.dbEncrypt(item, 0);
                Query = Query.Replace(item, item2);
            }

            if (Query.Contains("UpdatedBalance"))
            {
                string item = Query.Remove(0, Query.IndexOf("UpdatedBalance"));
                item = Regex.Match(item, @"\d+").Value;
                var item2 = await databaseHash.dbEncrypt(item, 4);
                Query = Query.Replace(item, item2);
            }

            if (Query.Contains("P_TransactionID"))
            {
                string item = Query.Remove(0, Query.IndexOf("P_TransactionID"));
                item = Regex.Match(item, @"\d+").Value;
                var item2 = await databaseHash.dbEncrypt(item, 3);
                Query = Query.Replace(item, item2);
            }
            return Query;
        }

        internal class databaseHash
        {
            public static async Task<char[]> initKeys(int KeyNum)
            {
                string[] returnValue = new string[6];

                returnValue[0] = "lrHvB4SBhqEqJSgI4pbw"; //MyQ UserID
                returnValue[1] = "joNYipgzSihArmsdxrjL"; //ParentPay UserID
                returnValue[2] = "i73tNh514FMplj9cybSm"; //MyQ Access Token
                returnValue[3] = "Gh7ZLvyi3mlV9SJxSXzX"; //ParentPay PaymentID
                returnValue[4] = "n6TyARAdGOIsJ0S1Ge3M"; //newBalance
                returnValue[5] = "jfiosru_fjsoruw3vva843"; //Database Password (for export)

                return Task.FromResult(returnValue[KeyNum].ToCharArray()).Result;
            }

            private static TripleDESCryptoServiceProvider GetCryproProvider(int keyNum)
            {
                var md5 = new MD5CryptoServiceProvider();
                var key = md5.ComputeHash(Encoding.UTF8.GetBytes(initKeys(keyNum).Result));
                return new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
            }

            public static async Task<string> dbEncrypt(string plainString, int keyNum)
            {
                var data = Encoding.UTF8.GetBytes(plainString);
                var tripleDes = GetCryproProvider(keyNum);
                var transform = tripleDes.CreateEncryptor();
                var resultsByteArray = transform.TransformFinalBlock(data, 0, data.Length);
                return Convert.ToBase64String(resultsByteArray);
            }

            public static async Task<string> dbDecrypt(string encryptedString, int keyNum)
            {
                var data = Convert.FromBase64String(encryptedString);
                var tripleDes = GetCryproProvider(keyNum);
                var transform = tripleDes.CreateDecryptor();
                var resultsByteArray = transform.TransformFinalBlock(data, 0, data.Length);
                return Encoding.UTF8.GetString(resultsByteArray);
            }
            public static async Task<decimal> decryptBalance(string enryptedBalance)
            {
                string tmp = await databaseHash.dbDecrypt(enryptedBalance.ToString(), 4);
                decimal balance = Convert.ToDecimal(tmp);

                return balance;
            }
        }
    }
}
