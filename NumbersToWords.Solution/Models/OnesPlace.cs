namespace NumbersToWords.Models
{
    public class OnesPlace
    {
        public static string GetString(int value)
        {
            return _onesPlace[value];
        }

        private static Dictionary<int, string> _onesPlace =
            new()
            {
                { 0, "zero" },
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" },
            };
    }
}
