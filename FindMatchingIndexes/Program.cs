using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMatchingIndexes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
                (string.Join(",",findMatchingIndexes(1, new int[] { 1, 11, 34, 52, 61 })));
            Console.ReadKey();
        }

        static int[] findMatchingIndexes(int givenNumber, int[] givenArray)
        {
            int counter = 0;
            var list = new List<int>();
            for (int i = 0; i < givenArray.Length; i++)
            {
                string convertedNumber = givenArray[i].ToString();
                string convertedNumber1 = givenNumber.ToString();
                if (convertedNumber.Contains(convertedNumber1))
                {
                    counter++;
                    
                }
            }
            int[] indexes = new int[counter];
            foreach (var item in list)
            {
                for (int i = 0; i < indexes.Length; i++)
                {

                    indexes[i] = item;
                    
                }
            }
            

            return indexes;
        }
    }
}
