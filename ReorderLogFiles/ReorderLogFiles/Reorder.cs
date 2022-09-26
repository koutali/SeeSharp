using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReorderLogFiles
{
    public class Reorder
    {
        public static string[] ReorderLogFiles(string[] logs)
        {
            var digits = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            var logsWithDigits = new List<string>();
            var logsWithLetter = new List<KeyValuePair<string, string>>();
            foreach (var log in logs)
            {
                GetIdentfierAndContent(log, out var identifier, out var content);

                if (digits.Any(content.ToString().Contains))
                {
                    logsWithDigits.Add(log);
                }
                else
                {
                    logsWithLetter.Add(new KeyValuePair<string, string>(identifier, content.ToString()));
                }
            }

            var orderedLogsWithLetter = logsWithLetter
                                                                    .OrderBy(x => x.Value)
                                                                    .ThenBy(x => x.Key).ToArray();

            var reorderedLogs = new List<string>();
            foreach (var pair in orderedLogsWithLetter)
            {
                reorderedLogs.Add(pair.Key + " " + pair.Value);
            }

            foreach (var log in logsWithDigits)
            {
                reorderedLogs.Add(log);
            }

            return reorderedLogs.ToArray();
        }

        private static void GetIdentfierAndContent(string log, out string identifier, out StringBuilder content)
        {
            var logSplit = log.Split(' ');
            identifier = logSplit[0];

            content = new StringBuilder();
            for (var i = 1; i < logSplit.Length -1; i++)
            {
                content.Append(logSplit[i] + " ");
            }

            content.Append(logSplit[^1]);
        }
    }
}
