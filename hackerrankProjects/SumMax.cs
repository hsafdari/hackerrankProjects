using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankProjects
{
    public static class SumMax
    {
        public static string Program(string arg)
        {
            // code goes here  
            var _numbers = arg.Split(",").Select(Int32.Parse)?.ToList();
            List<int> _max = new List<int>();
            for (int i = 0; i < _numbers.Count - 1; i++)
            {
                int number = lcm(_numbers[i], _numbers[i + 1]);
                _max.Add(number);
            }
            arg = _max.Max(x => x).ToString();
            return arg;

        }
        static int Gcf(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int lcm(int a, int b)
        {
            return (a / Gcf(a, b)) * b;
        }
        //static void Main()
        //{
        //    // keep this function call here
        //    string list = "10,15,25,35,40,50,55";
        //    Console.WriteLine(Program(list));
        //}
    }
}
