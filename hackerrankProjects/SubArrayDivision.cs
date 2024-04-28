using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankProjects
{
    public static class SubArrayDivision
    {     
        public static int birthday(List<int> s, int d, int m)
        {
            int size = s.Count;
            int ways = 0;
            for (int i = 0; i <= size - m; i++)
            {
                if (s.GetRange(i, m).Sum() == d)
                {
                    ways++;
                }
            }

            return ways;
        }
    }
}
