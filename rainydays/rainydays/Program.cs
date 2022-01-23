using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rainydays
{
    internal class Program
    {
        static List<string> cities = new List<string> { "Bp","Bp","Gyor","Gyor","DB","Gyor"};
        static void Main(string[] args)
        {
            var dy = new Dictionary<string, int>();
            foreach (var item in cities)
            {
                if (!dy.ContainsKey(item))
                {
                    dy.Add(item, 1);
                }
                else
                {
                    dy[item]++;
                }

            }

            int max = int.MinValue;
            string city = string.Empty;
            foreach (var item in dy)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    city = item.Key;
                }
            }

            Console.WriteLine(city);
            Console.ReadKey();
        }
    }
}
