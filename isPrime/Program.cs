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
            int[] numbers = { 0, 1, 2, 43, 55, 97, 22, 88, 67, 71 };

            int result = IsPrime(numbers);
            Console.WriteLine("\n   A tömben található prímszámok száma: " + result);


            Console.ReadKey();
        }

        static int IsPrime(int[] givenArray)
        {

            int osztokSzama = 0;
            int oszto = 1;
            int Quantity = 0;

            for (int i = 0; i < givenArray.Length; i++)
            {

                if (givenArray[i] > 2)
                {

                    if (givenArray[i] % oszto == 0)
                    {
                        oszto++;
                        osztokSzama++;
                    }

                    if (osztokSzama == 2)
                        Quantity++;
                }
                else if (givenArray[i] > 0)
                    Quantity++;

            }
            return Quantity;
        }

    }
}
