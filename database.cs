using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GW_Utility_V3
{
    internal class database
    {
        internal static ConnectionStringSettings connectionStringSettings { get; set; }

        internal static async Task<SqlCeConnection> ConnectAsync(SqlCeConnection conn = null)
        {
            try
            {
                if (await CopyDatabase())
                {
                    connectionStringSettings = new ConnectionStringSettings();
                    connectionStringSettings.ConnectionString = "DataSource=db.sdf;Password=" + await databaseHash.dbDecrypt(gatewayProperties.Properties.DatabasePassword, 5);

                    conn = new SqlCeConnection(connectionStringSettings.ConnectionString);
                }
            }

            catch (Exception ex)
            {
                //Error
            }

            return conn;
        }

        internal static async Task<bool> CopyDatabase(bool returnValue = false)
        {
            var copyDatabase = Task.Run(() => File.Copy(gatewayProperties.Properties.DatabaseLocation, AppDomain.CurrentDomain.BaseDirectory + "db.sdf"));
            copyDatabase.Wait();

            if (File.Exists("db.sdf"))
                returnValue = true;

            return returnValue;
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

        internal class databaseHash
        {
            public static async Task<char[]> initKeys(int KeyNum)
            {
                string[] returnValue = new string[6];

                //
                returnValue[0] = "lrHvB4SBhqEqJSgI4pbw";

                //
                returnValue[1] = "joNYipgzSihArmsdxrjL";

                //
                returnValue[2] = "i73tNh514FMplj9cybSm";

                //
                returnValue[3] = "Gh7ZLvyi3mlV9SJxSXzX";

                //
                returnValue[4] = "n6TyARAdGOIsJ0S1Ge3M";

                //Used for encrypting the database password export...
                returnValue[5] = "djfiosru_fjsoruw3vva843";

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
