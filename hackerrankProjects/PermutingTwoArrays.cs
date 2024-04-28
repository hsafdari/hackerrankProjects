using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hackerrankProjects
{
    internal class PermutingTwoArrays
    {

        /// <summary>
        /// The function is expected to return a STRING
        /// </summary>
        /// <param name="k">INTEGER k</param>
        /// <param name="A">INTEGER_ARRAY A</param>
        /// <param name="B">INTEGER_ARRAY B</param>
        /// <returns></returns>
        public static string twoArrays(int k, List<int> A, List<int> B)
        {
            List<int> A1 = A.OrderBy(x => x).ToList();
            List<int> B1 = B.OrderByDescending(x => x).ToList();
            for (int i = 0; i < A.Count; i++)
            {
                if (A1[i] + B1[i]<k)
                {
                    return "NO";
                }
            }
            return "YES";
        }
        //public static void Main(string[] args)
        //{

        //    Console.WriteLine(PermutingTwoArrays.twoArrays(5, [1, 2, 2, 1], [3, 3, 3, 4]));
        //}
    }
}
