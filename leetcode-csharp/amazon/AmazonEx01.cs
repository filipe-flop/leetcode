using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml;

namespace leetcode_csharp.amazon
{
    public class AmazonEx01
    {
        //Your Amazonian team is responsible for maintaining a monetary transaction service.The transactions are tracked in a log file.
        //A log file is provided as a string array where each entry represents a transaction to service.Each transaction consists of:
        //- sender_user_id: Unique identifier for the user that initiated the transaction.  It consists of only digits with at most 9 digits.
        //- recipient_user_id:  Unique identifier for the user that is receiving the transaction.It consists of only digits with at most 9 digits.
        //- amount_of_transaction: The amount of the transaction.It consists of only digits with at most 9 digits.
        //The values are separated by a space.For example, "sender_user_id recipient_user_id amount_of_transaction".
        //Users that perform an excessive amount of transactions might be abusing the service so you have been tasked to identify the users that have a number of transactions over a threshold.
        //The list of user ids should be ordered in ascending numeric value.

        public static List<string> processLogs(List<string> logs, int threshold)
        {
            Dictionary<string, int> logsDic = new Dictionary<string, int>();

            foreach (string log in logs)
            {
                string[] parts = log.Split(' ');

                if (parts.Length > 2)
                {
                    string key1 = parts[0];
                    string key2 = parts[1];

                    if (logsDic.ContainsKey(key1))
                    {
                        logsDic[key1]++;
                    }
                    else
                    {
                        logsDic.Add(key1, 1);
                    }

                    if (logsDic.ContainsKey(key2))
                    {
                        logsDic[key2]++;
                    }
                    else
                    {
                        logsDic.Add(key2, 1);
                    }
                }
                else
                {
                    continue;
                }
            }

            foreach (var key in logsDic.Where(kv => kv.Value < threshold).Select(kv => kv.Key).ToList())
            {
                logsDic.Remove(key);
            }

            return logsDic.Keys.OrderBy(k => int.Parse(k)).ToList();
        }
    }
}
