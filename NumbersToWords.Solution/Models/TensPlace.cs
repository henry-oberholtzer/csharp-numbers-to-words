namespace NumbersToWords.Models
{
    public class TensPlace
    {
        public static string GetString(int value)
        {
            if (value < 20 && value > 9)
            {
                return _tensPlace[value];
            }
            else if (value < 100)
            {
                int remainder = value % 10;
                int tens = value / 10;
                if (tens == 0)
                {
                    return "";
                }
                else if (remainder > 0)
                {
                    return _tensPlace[tens] + " " + OnesPlace.GetString(remainder);
                }
                else
                {
                    return _tensPlace[tens];
                }
            }
            else
            {
                return "Too large!";
            }
        }

        private static Dictionary<int, string> _tensPlace =
            new()
            {
                { 10, "ten" },
                { 11, "eleven" },
                { 12, "twelve" },
                { 13, "thirteen" },
                { 14, "fourteen" },
                { 15, "fifteen" },
                { 16, "sixteen" },
                { 17, "seventeen" },
                { 18, "eighteen" },
                { 19, "nineteen" },
                { 2, "twenty" },
                { 3, "thirty" },
                { 4, "forty" },
                { 5, "fifty" },
                { 6, "sixty" },
                { 7, "seventy" },
                { 8, "eighty" },
                { 9, "ninety" }
            };
    }
}
