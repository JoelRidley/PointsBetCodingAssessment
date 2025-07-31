using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{
    /*
    Changes:
        - Added empty list check to prevent error
        - Adjusted the Append in loop to use AppendFormat instead of Append(string.Format)
        - Comment to describe function
    */
    public class StringFormatter
    {
        //inputs a list and quote
        //returns each item in list surrounded by qoute, comma separated into one string
        public static string ToCommaSepatatedList(string[] items, string quote)
        {
            if (items.Length == 0) return "";

            StringBuilder output = new StringBuilder(string.Format("{0}{1}{0}", quote, items[0]));

            for (int i = 1; i < items.Length; i++)
            {
                output.AppendFormat(", {0}{1}{0}", quote, items[i]);
            }

            return output.ToString();
        }
    }
}
