using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankProjects
{
    internal class PlusMinus
    {
        class Result
        {
            public static void plusMinus(List<int> arr)
            {
                double _positiveCount = 0, _negativeCount = 0, _zeroCount = 0;                 
                Console.WriteLine(string.Format("{0:n6}", arr.Where(x => x > 0).Count() / (double)arr.Count));
                Console.WriteLine(string.Format("{0:n6}", arr.Where(x => x < 0).Count() / (double)arr.Count));
                Console.WriteLine(string.Format("{0:n6}", arr.Where(x => x == 0).Count() / (double)arr.Count));

            }
        }
        //class Solution
        //{
        //    public static void Main(string[] args)
        //    {
        //        List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };
        //        Result.plusMinus(arr);
        //    }
        //}
    }
}
