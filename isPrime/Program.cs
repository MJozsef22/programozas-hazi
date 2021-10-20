using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 2, 2, 43, 55, 97, 22, 67, 88, 71 };
            int count = 0;
            foreach (int item in numbers)
            {
                if (isPrime(item))
                {
                    count++;
                }
            }

            Console.WriteLine("\n   A tömben található prímszámok száma: " + count);


            Console.ReadKey();
        }

        static bool isPrime(int givenNumber)
        {
            int a = 0;

            for (int j = 1; j <= givenNumber; j++)
            {
                if (givenNumber % j == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return true;
            }
            return false;
        }

    }
}
