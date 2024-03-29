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
                //foreach (var item in arr)
                //{
                //    switch (item)
                //    {
                //        case 0:
                //            {
                //                _zeroCount++;
                //                break;
                //            }
                //        case > 0:
                //            {
                //                _positiveCount++;
                //                break;
                //            }
                //        case < 0:
                //            {
                //                _negativeCount++;
                //                break;
                //            }
                //    }
                //}
                ////_positiveCount = arr.Where(x => x > 0).Count();
                ////_negativeCount=arr.Where(x=>x<0).Count();
                ////_zeroCount=arr.Where(x=>x==0).Count();

                //double _positive =_positiveCount / (double)arr.Count;
                //double _negative = _negativeCount / (double)arr.Count;
                //double _zero = _zeroCount / (double)arr.Count;   
                Console.WriteLine(string.Format("{0:n6}", arr.Where(x => x > 0).Count() / (double)arr.Count));
                Console.WriteLine(string.Format("{0:n6}", arr.Where(x => x < 0).Count() / (double)arr.Count));
                Console.WriteLine(string.Format("{0:n6}", arr.Where(x => x == 0).Count() / (double)arr.Count));

            }
        }
        class Solution
        {
            public static void Main(string[] args)
            {

                //int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };
                //Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                Result.plusMinus(arr);
            }
        }
    }
}
