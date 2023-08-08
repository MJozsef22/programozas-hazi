using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrabalaton
{
    class Beolv
    {
        public string versenyzo { get; private set; }
        public int rajtszam { get; private set; }
        public string kategoria { get; private set; }
        public TimeSpan versIdo { get; private set; }

        public int tavszaz { get; private set; }
        public bool teljesitette { get; private set; }

        public Beolv(string s)
        {
            string[] temp = s.Split(';');
            versenyzo = temp[0];
            rajtszam = int.Parse(temp[1]);
            kategoria = temp[2];
            string[] ido = temp[3].Split(':');
            versIdo = new TimeSpan(int.Parse(ido[0]),int.Parse(ido[1]),int.Parse(ido[2]));
            tavszaz = int.Parse(temp[4]);
            if (int.Parse(temp[4]) == 100)
            {
                teljesitette = true;
            }
            else
                teljesitette = false;
        }
    }
    internal class Program
    {
        static List<Beolv> data = new List<Beolv>();
        static void Main(string[] args)
        {
            foreach (var item in File.ReadAllLines("ub2017egyeni.txt").Skip(1))
            {
                data.Add(new Beolv(item));
            }

            Console.WriteLine($"3.feladat: Egyéni indulók: {data.Count} fő");

            int countNo = 0;
            foreach (var item in data)
            {
                if (item.kategoria == "Noi" && item.teljesitette ==true)
                {
                    countNo++;
                }
            }
            Console.WriteLine($"4.feladat: Célba érkező női sportolók: {countNo} fő");

            Console.Write($"5.feladat: Kérem a sportoló nevét?: ");
            string nev = Console.ReadLine();

            bool indult = false;
            bool teljesitette = false;
            foreach (var item in data)
            {
                if (item.versenyzo == nev)
                {
                    indult = true;
                    if (item.teljesitette == true)
                    {
                        teljesitette = true;
                        break;
                    }
                    else
                    {
                        teljesitette = false;
                        break;
                    }
                }
                indult = false;
            }

            Console.WriteLine($"\tIndult egyéniben a sportoló? {(indult ? "Igen" :"Nem")}");
            Console.WriteLine($"\tTeljesítette a teljes távot? {(teljesitette ? "Igen" : "Nem")}");

            double osszora = 0;
            int countFerfi = 0;
            foreach (var item in data)
            {
                if (item.kategoria =="Ferfi" && item.teljesitette == true)
                {
                    countFerfi++;
                    osszora += item.versIdo.TotalHours;
                }
            }
            double atlag = osszora/ countFerfi;
            Console.WriteLine(atlag);

            Console.ReadKey();
        }
    }
}
