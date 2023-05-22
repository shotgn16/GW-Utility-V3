using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW_Utility_V3.data
{
    internal class serializers
    {
        internal static async Task<object> serializeTransactions(string input)
        {
            var serializedClass = JsonConvert.SerializeObject(input);
            return serializedClass;
        }
    }

    internal class Transaction : serializers
    {
        public static Transaction transactions = new Transaction();
        internal string MyQUserID { get; set; }
        internal string ParentPayID { get; set; }
        internal string ParentPayTransactionID { get; set; }
    }
}
