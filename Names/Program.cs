using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            start(names);
            Console.ReadKey();
        }

        #region SecondMain
        static void start(List<string> givenList)
        {
            Console.WriteLine("\n   A lista elemeinek száma: " + numbersOfelement(givenList));
            addName(ref givenList, "Wiliam");
            Console.WriteLine(isEmpty(givenList) ? "\n   A lista nem üres!" : "\n   A lista üres!");
            addName(ref givenList, "John");
            addName(ref givenList, "Amanda");
            Console.WriteLine("\n   A lista elemeinek száma: " + numbersOfelement(givenList));
            Console.WriteLine("\n   A lista harmadik eleme: " + givenList[2]);
            printOuteachName(givenList);
            listAndprint(givenList);
            removeThesecondElement(ref givenList);
            reversed(givenList);
            removeAll(ref givenList);

            Console.WriteLine(isEmpty(givenList) ? "\n   A lista nem üres!" : "\n   A lista üres!");

        }
        #endregion 

        #region Metods
        static int numbersOfelement(List<string> givenList)
        {
            return givenList.Count;
        }

        static List<string> addName(ref List<string> givenList, string Name)
        {
            givenList.Add(Name);
            return givenList;
        }
        static bool isEmpty(List<string> givenList)
        {

            if (givenList.Count > 0)
            {
                return true;
            }
            return false;
        }

        static void printOuteachName(List<string> givenList)
        {
            Console.WriteLine("\n");
            foreach (string item in givenList)
            {
                Console.WriteLine("   " + item);
            }
        }
        static void listAndprint(List<string> givenList)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < givenList.Count; i++)
            {
                Console.Write("   {0}.", i + 1);
                Console.Write(givenList[i] + "\n");
            }
        }

        static List<string> removeThesecondElement(ref List<string> givenList)
        {
            givenList.Remove(givenList[1]);
            return givenList;
        }

        static void reversed(List<string> givenList)
        {
            Console.WriteLine("\n");
            for (int i = givenList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine("   " + givenList[i]);
            }
        }

        static List<string> removeAll(ref List<string> givenList)
        {
            givenList.Clear();
            return givenList;
        }
        #endregion 
    }
}
