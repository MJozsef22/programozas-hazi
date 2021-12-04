using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static Dictionary<string, int> products = new Dictionary<string, int>{
            { "eggs",200},
            { "milk", 200},
            { "fish", 400},
            { "apples", 150},
            { "bread", 50},
            { "chicken", 550}
        };
        static void Main(string[] args)
        {

            Console.WriteLine("How much is the fish?");
            Console.WriteLine(products["fish"]);
            Console.WriteLine("What is the most expensive product?");
            string key = "";
            int highest = 0;
            foreach (var item in products)
            {
                if (highest < item.Value)
                {
                    highest = item.Value;
                    key = item.Key;
                }
            }
            Console.WriteLine(key);
            Console.WriteLine("What is the average price?");
            double sum = 0;
            foreach (var item in products)
            {
                sum += item.Value;
            }
            sum = sum / products.Count;
            Console.WriteLine(sum);
            Console.WriteLine("How many products' price is below 300?");
            int counter = 0;
            foreach (var item in products)
            {
                if (item.Value < 300)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            Console.WriteLine("Is there anything we can buy for exactly 125?");
            Console.WriteLine(products.ContainsValue(125)? "yes":"no");
            Console.WriteLine("What is the cheapest product?");
            int cheapest = 1000;
            string cica = "";
            foreach (var item in products)
            {
                if (cheapest > item.Value)
                {
                    cheapest = item.Value;
                    cica = item.Key;
                }
            }
            Console.WriteLine(cica);
            Console.ReadKey();
        }
    }
}
