using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankProjects
{
    internal class LonelyInteger
    {
        public static int lonelyinteger(List<int> a)
        {
            var item = a.GroupBy(x => x).Select(y => new
            {
                number = y.Key,
                count = y.Count()
            }).Where(x => x.count == 1).FirstOrDefault();
                     
            return item!=null?item.number:0;
        }
    }
}
