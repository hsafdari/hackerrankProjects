using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hackerrankProjects
{
    internal static class MachAlphabet
    {
        public static string pangrams(string s)
        {
            s = s.ToLower();
            List<char> items =new List<char>();
            for (char x='a';x<='z';x++)
            {
                items.Add(x);
            }          
            var result=items.Where(x => !s.Contains(x)).ToList();
            if (result.Count==0)
            {
                return "pangram";
            }
            else
            {
                return "not pangram";
            }
        }
        //public static void Main(string[] args)
        //{

        //    Console.WriteLine(MachAlphabet.pangrams("We promptly judged antique ivory buckles for the next prize"));
        //}
    }
}
