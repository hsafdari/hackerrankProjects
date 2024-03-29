using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankProjects
{
    internal class SparseArrays
    {
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> _results = new List<int>();
            foreach (string q in queries) {
                int _count = strings.Where(x => x == q).Count();
                _results.Add(_count);                
            }
            return _results;
        }
    }
}
