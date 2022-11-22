using System.Text;

namespace Sociolite.Data
{
    public class RecurranceManager
    {
        private Dictionary<string, int> DayNumbersByNames = new Dictionary<string, int>()
        {
            ["Monday"] = 0,
            ["Tuesday"] = 1,
            ["Wednesday"] = 2,
            ["Thursday"] = 3,
            ["Friday"] = 4,
            ["Saturday"] = 5,
            ["Sunday"] = 6
        };

        private Dictionary<int, string> DayNamesByNumbers = new Dictionary<int, string>()
        {
            [0] = "Monday",
            [1] = "Tuesday",
            [2] = "Wednesday",
            [3] = "Thursday",
            [4] = "Friday",
            [5] = "Saturday",
            [6] = "Sunday"
        };

        public string BuildRecurranceString(List<string> daysToRun, string occurAtTime)
        {
            string temp = "0000000";

            foreach (var day in daysToRun)
            {
                StringBuilder sb = new StringBuilder(temp);
                sb[DayNumbersByNames[day]] = '1';
                temp = sb.ToString();
            }

            temp = temp + occurAtTime.Replace(":", "");

            return temp;
        }

        public string ConvertRecurranceStringToReadableFormat(string recurranceString)
        {
            string days = recurranceString.Remove(7, 4);
            string hours = recurranceString.Remove(0, 7).Remove(2, 2);
            string minutes = recurranceString.Remove(0, 9);

            string readableString = "Happens ";

            List<string> daysToOccur = new List<string>();

            // Populate list
            for (int i = 0; i < days.Length; i++)
            {
                if (days[i] == '1')
                {
                    daysToOccur.Add(DayNamesByNumbers[i]);
                }
            }

            if (days.Equals("1111111")) 
            {
                readableString += " every day at ";
            } else if (days.Equals("1111100"))
            {
                readableString += " every week-day at ";
            } else
            {
                for (int i = 0; i < daysToOccur.Count; i++)
                {
                    if (i == daysToOccur.Count - 1) // Skip comma if last day on list
                    {
                        readableString += daysToOccur[i] + " at ";
                    } else
                    {
                        readableString += daysToOccur[i] + ", ";
                    }
                }
            }

            readableString += hours + ":" + minutes;

            return readableString;
        }
    }
}
