namespace NumbersToWords.Models
{
    public class StringBuilder
    {
        public static string GetString(long value)
        {
            if (value < 10)
            {
                return OnesPlace.GetString((int)value);
            }
            else if (value < 100)
            {
                return TensPlace.GetString((int)value);
            }
            else
            {
                return PowersOfTen.GetString(value);
            }
        }
    }
}
