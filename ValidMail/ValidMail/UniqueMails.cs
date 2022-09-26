namespace ValidMail
{
    public class UniqueMails
    {
        public static int NumUniqueEmails(string[] emails)
        {
            var uniqueMails = new HashSet<string>();

            foreach (var email in emails)
            {
                var splitted = email.Split('@');
                if (splitted.Length == 0)
                    continue;

                var localName = splitted[0];

                // remove .
                if (localName.Contains("."))
                    localName = localName.Replace(".", string.Empty);
                
                if(string.IsNullOrEmpty(localName))
                    continue;

                var indexOfPlus = localName.IndexOf("+", StringComparison.Ordinal);
                if (indexOfPlus > 0)
                    localName = localName.Remove(indexOfPlus);

                uniqueMails.Add(localName +"@" +splitted[1]);
            }

            return uniqueMails.Count();
        }
    }
}