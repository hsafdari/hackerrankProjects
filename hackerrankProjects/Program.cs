using System.Collections.Specialized;
using System.Configuration;

namespace hackerrankProjects
{
    public class Programm
    {

        public Programm()
        {
           // var item = new MiniMaxSum.Solution();
        }
        public static void Main(string[] args)
        {
            var _setting = ConfigurationManager.GetSection("appSettings") as NameValueCollection;
            string _name = _setting.Get("OUTPUT_PATH");
            TextWriter textWriter = new StreamWriter(_name, true);

           // int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();
            var item = File.ReadAllLines("readData.txt");
            for (int i = 1; i <= int.Parse(item[0]); i++)
            {
                arr.Add(item[i].TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference.Difference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}


