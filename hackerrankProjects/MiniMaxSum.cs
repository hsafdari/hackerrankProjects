using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankProjects
{
    public class MiniMaxSum
    {
        class Result
        {

            /*
             * Complete the 'miniMaxSum' function below.
             *
             * The function accepts INTEGER_ARRAY arr as parameter.
             */

            public static void miniMaxSum(List<int> arr)
            {
                int _min = arr.Min();
                int _max = arr.Max();
                var _MinIndex = arr.FindIndex(x=>x==_min);
                arr.RemoveAt(_MinIndex);
                var _MaxIndex = arr.FindIndex(x => x == _max);
                arr.RemoveAt(_MaxIndex);
                long sum= arr.Select(x => (long)x).Sum();              
                Console.Write(string.Format("{0} {1}", sum+ _min, sum +_max)); 
               
            }

        }

        public class Solution
        {
            public Solution()
            {
                List<int> arr = new List<int> { 942381765, 627450398, 954173620, 583762094 ,236817490 };
                Result.miniMaxSum(arr);
            }
        }
    }
}
