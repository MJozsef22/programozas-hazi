using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace playfair
{
    class PlayfairKodolo
    {
        private List<string> codeTable;
        public PlayfairKodolo(string fajnev)
        {
            codeTable = new List<string>();
            foreach (var item in File.ReadAllLines(fajnev))
                codeTable.Add(item);
        }

        public int SorIdex(char betu)
        {
            for (int i = 0; i < codeTable.Count; i++)
            {
                if (codeTable[i].Contains(betu.ToString()))
                {
                    return i;
                }
            }
            return -1;
        }

        public string KodolBetupar()

        public int OszlopIdex(char betu)
        {
            for (int sor = 0; sor < codeTable.Count; sor++)
            {
                for (int oszlop = 0; oszlop < codeTable[sor].Length; oszlop++)
                {
                    if (codeTable[sor][oszlop] == betu)
                    {
                        return oszlop;
                    }
                }

            }
            return -1;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayfairKodolo fajlnev = new PlayfairKodolo("kulcstabla.txt");
            Console.Write("6.feladat - Kérek egy nagy betűt(Az angol ábécéből és a Q kivételével): ");
            string karakter = Console.ReadLine();
            Console.WriteLine($"A karakter sorának az indexe: {fajlnev.SorIdex(karakter.First())}");
            Console.WriteLine($"A karakter oszlop az indexe: {fajlnev.OszlopIdex(karakter.First())}");



            Console.ReadKey();
        }
    }
}
