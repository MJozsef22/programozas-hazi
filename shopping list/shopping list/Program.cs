using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string> {"eggs","milk","fish", "apples","bread","chicken" };
            Console.WriteLine(shoppingList.Contains("milk")? "Yes":"No");
            Console.WriteLine(shoppingList.Contains("banana")? "Yes":"No");
            Console.ReadLine();
        }
    }
}
