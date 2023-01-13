using System;
using System.Collections.Generic;
using System.Text;

namespace _13._01._23
{
    class SubString
    {
        internal static string DifferenceTime(string time1,string time2)
        {
            //09:30:00   12:45:30
            int h1 = int.Parse(time1.Substring(0, 2));
            int m1 = int.Parse(time1.Substring(3, 2));
            int s1 = int.Parse(time1.Substring(6, 2));

            int h2 = int.Parse(time1.Substring(0, 2));
            int m2 = int.Parse(time1.Substring(3, 2));
            int s2 = int.Parse(time1.Substring(6, 2));

            int difference = h2 * 3600 + m2 * 60 + s2 - (h1 * 3600 + m1 * 60 + s1);

            return $"{(difference / 3600).ToString().PadLeft(2, '0')}:{(difference % 3600) / 60}: {difference % 3600 }";
        }
    }
}
