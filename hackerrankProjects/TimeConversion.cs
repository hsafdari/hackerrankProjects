using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankProjects
{
    internal class TimeConversion
    {
        public static string timeConversion(string s)
        {
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }
    }
}
