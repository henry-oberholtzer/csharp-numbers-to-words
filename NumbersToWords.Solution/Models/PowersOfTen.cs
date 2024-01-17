namespace NumbersToWords.Models
{
    public class PowersOfTen
    {
        public static string GetString(long value)
        {
            if (value > (long)1e+013)
            {
                return "Maximum value (9,999,999,999,999) exceeded";
            }
            // long trillionsPlace = value % (long)1e+013;
            // int trillionsCount = Convert.ToInt32(trillionsPlace / (long)1e+012);

            // long hundredBillionsPlace = trillionsPlace % (long)1e+012;
            // int hundredBillionsCount = Convert.ToInt32(hundredBillionsPlace / (long)1e+011);

            long tenBillionsPlace = value % (long)1e+011;
            int tenBillionsCount = Convert.ToInt32(tenBillionsPlace / (long)1e+010);

            long billionsPlace = tenBillionsPlace % (long)1e+010;
            int billionsCount = Convert.ToInt32(billionsPlace / (long)1e+009);

            long hundredMillionsPlace = billionsPlace % (long)1e+010;
            int hundredMillionsCount = Convert.ToInt32(hundredMillionsPlace / (long)1e+08);

            long tenMillionsPlace = hundredMillionsPlace % (long)1e+008;
            int tenMillionsCount = (int)tenMillionsPlace / (int)1e+006;

            long millionsPlace = tenMillionsPlace % (long)1e+007;
            int millionsCount = (int)millionsPlace / (int)1e+006;

            int hundredThousandsPlace = Convert.ToInt32(millionsPlace % (long)1e+006);
            int hundredThousandsCount = hundredThousandsPlace / 100000;

            int tenThousandsPlace = hundredThousandsPlace % 100000;
            int tenThousandsCount = tenThousandsPlace / 1000;

            int thousandsPlace = (int)value % 10000;
            int thousandsCount = thousandsPlace / 1000;

            int hundredsPlace = thousandsPlace % 1000;
            int hundredsCount = hundredsPlace / 100;

            int tensRemainder = hundredsPlace % 100;

            string tensString = TensPlace.GetString(tensRemainder);
            string hundredsString =
                hundredsCount > 0 ? OnesPlace.GetString(hundredsCount) + " hundred " : "";
            string thousandsString;
            if (tenThousandsCount > 0)
            {
                thousandsString = TensPlace.GetString(tenThousandsCount) + " thousand ";
            }
            else
            {
                thousandsString =
                    thousandsCount > 0 ? OnesPlace.GetString(thousandsCount) + " thousand " : "";
            }
            string hundredThousandsString =
                hundredThousandsCount > 0
                    ? OnesPlace.GetString(hundredThousandsCount) + " hundred "
                    : "";
            string millionsString;
            if (tenMillionsCount > 0)
            {
                Console.WriteLine(tenMillionsCount);
                millionsString = TensPlace.GetString(tenMillionsCount) + " million ";
            }
            else
            {
                millionsString =
                    millionsCount > 0 ? OnesPlace.GetString(millionsCount) + " million " : "";
            }
            string hundredMillionsString =
                hundredMillionsCount > 0
                    ? OnesPlace.GetString(hundredMillionsCount) + " hundred "
                    : "";
            string billionsString;
            if (tenBillionsCount > 0)
            {
                billionsString = TensPlace.GetString(tenBillionsCount) + " billion ";
            }
            else
            {
                billionsString =
                    billionsCount > 0 ? OnesPlace.GetString(billionsCount) + " billion " : "";
            }
            // string hundredBillionsString =
            //     hundredBillionsCount > 0
            //         ? OnesPlace.GetString(hundredBillionsCount) + " hundred "
            //         : "";

            // return hundredBillionsString
            //     + billionsString
            //     + hundredMillionsString
            //     + millionsString
            return billionsString
                + hundredMillionsString
                + millionsString
                + hundredThousandsString
                + thousandsString
                + hundredsString
                + tensString;
        }
    }
}
