using System.Text.RegularExpressions;

namespace App
{
    public static class Extensions
    {
        private static readonly Random Random = new Random(Guid.NewGuid().GetHashCode());

        public static readonly Regex NumberRegex = new Regex(@"^\d+$", RegexOptions.Compiled);

        public static string RandomString(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}
