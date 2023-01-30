using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurzio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hány nyúl fülét szeretnéd megszámolni?: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n{0} füle van {1} nyúlnak",szamolas(n),n);
            Console.ReadKey();
        }
        static int szamolas(int givenInt)
        {
            if (givenInt <= 0)
            {
                return 0;
            }
            if (givenInt == 2)
            {
                return 4;
            }
            else
            {
                return 2 + szamolas(givenInt - 1);
            }
        }
    }
}
