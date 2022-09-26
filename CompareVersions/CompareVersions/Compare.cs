using System;
using System.Text;

namespace CompareVersions
{
    public class Compare
    {
        public static int CompareVersions(string version1, string version2)
        {
            if (string.IsNullOrEmpty(version1))
            {
                throw new ArgumentException(nameof(version1));
            }

            if (string.IsNullOrEmpty(version2))
            {
                throw new ArgumentException(nameof(version2));
            }

            var version1Split = version1.Split('.');
            var version1Converted = RemoveTrailingZeros(version1Split);

            var version2Split = version2.Split('.');
            var version2Converted = RemoveTrailingZeros(version2Split);

            return CheckForEquality(version1Converted, version2Converted);
        }

        private static int CheckForEquality(string[] version1Converted, string[] version2Converted)
        {
            var length = version1Converted.Length;
            if (version2Converted.Length < version1Converted.Length)
            {
                length = version2Converted.Length;
            }

            for (var i = 0; i < length; i++)
            {
                if (version1Converted[i] == version2Converted[i]) continue;

                int.TryParse(version1Converted[i], out var converted1);
                int.TryParse(version2Converted[i], out var converted2);

                if (converted1 > converted2)
                {
                    return 1;
                }

                return -1;
            }

            var valueAsInt1 = ConvertToInt(version1Converted);
            var valueAsInt2 = ConvertToInt(version2Converted);

            if (valueAsInt1 > valueAsInt2)
            {
                return 1;
            }

            if (valueAsInt2 > valueAsInt1)
            {
                return -1;
            }

            return 0;
        }

        private static string[] RemoveTrailingZeros(string[] versionSplit)
        {
            for (var i = 0; i < versionSplit.Length; i++)
            {
                versionSplit[i] = versionSplit[i].TrimStart('0');
            }

            return versionSplit;
        }

        public static int ConvertToInt(string[] version)
        {
            var sb = new StringBuilder();
            foreach (var subVersion in version)
            {
                sb.Append(subVersion);
            }

            int.TryParse(sb.ToString(), out var converted);

            return converted;
        }
    }
}
