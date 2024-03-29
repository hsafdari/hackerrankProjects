using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankProjects
{
    public static class diagonalDifference
    {
        public static int Difference(List<List<int>> arr)
        {
            int leftmatrix=0,rightmatrix = 0;
            for (int i = 0, t = arr[i].Count-1; i < arr.Count; i++, t--)
            {
                leftmatrix += arr[i][i];                
                rightmatrix += arr[i][t];
            }

            return Math.Abs(leftmatrix - rightmatrix);
        }
    }
}
