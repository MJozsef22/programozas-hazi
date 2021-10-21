using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_finance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 500, 1000, 1250, 175, 800, 120 };
            start(numbers);
            Console.ReadKey();
        }

        #region SecondMain
        static void start(List<int> givenList)
        {

            Console.WriteLine("\n   Ennyit költöttünk: " + howMuchdidWespen(givenList));
            Console.WriteLine("\n   Ez a legnagyobb kiadás: " + whichWasourGreatestexpense(givenList));
            Console.WriteLine("\n   Ez a kisebb kiadás: " + whichWasourCheapestexpense(givenList));
            Console.WriteLine("\n   Ez az átlag kiadás: " + averageAmountofOurspending(givenList));

        }
        #endregion

        #region Metods
        static int howMuchdidWespen(List<int> givenList)
        {
            int sum = 0;
            foreach (int item in givenList)
            {
                sum += item;
            }
            return sum;
        }

        static int whichWasourGreatestexpense(List<int> givenList)
        {
            return givenList.Max();
        }
        static int whichWasourCheapestexpense(List<int> givenList)
        {
            return givenList.Min();
        }

        static double averageAmountofOurspending(List<int> givenList)
        {
            return Math.Round((howMuchdidWespen(givenList) * 1.0 / givenList.Count), 2);
        }
        #endregion
    }
}
