using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankProjects
{
    internal static class SortingAlternative
    {
        public static List<int> countingSort(List<int> arr)
        {         
            List<int> result = new List<int>(new int[100]);
            for (int i = 0; i < arr.Count; i++)
            {               
                result[arr[i]]++;
            }
            return result;

        }
        //public static void Main(string[] args)
        //{
        //    // keep this function call here
        //    string _mylist = "63 54 17 78 43 70 32 97 16 94 74 18 60 61 35 83 13 56 75 52 70 12 24 37 17 0 16 64 34 81 82 24 69 2 30 61 83 37 97 16 70 53 0 61 12 17 97 67 33 30 49 70 11 40 67 94 84 60 35 58 19 81 16 14 68 46 42 81 75 87 13 84 33 34 14 96 7 59 17 98 79 47 71 75 8 27 73 66 64 12 29 35 80 78 80 6 5 24 49 82";
        //    List<int> list = _mylist.Split(' ').ToList().Select(x => Convert.ToInt32(x)).ToList();                 
        //    Console.WriteLine(SortingAlternative.countingSort(list));
        //}
    }
}
