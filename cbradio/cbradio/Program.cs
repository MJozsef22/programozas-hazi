using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace cbradio
{
    internal class Program
    {
        static List<Read> data = new List<Read>();
        static void Main(string[] args)
        {
            if (File.Exists("cb.txt"))
            {
                string[] temp = File.ReadAllLines("cb.txt");
                foreach (var item in temp.Skip(1))
                {
                    data.Add(new Read(item));
                }

                Console.WriteLine($"3. feladat: { data.Count}db");


                string TorF = "Nincs olyan soför";
                foreach (var item in data)
                {
                    if (item.perc == 1 && item.adasdb == 4)
                    {
                        TorF = "Volt olyan soför";
                    }
                }
                Console.WriteLine($"4. feladat:{TorF}");

                Console.Write("5. feladat: Kérek egy nevet:");
                string name = Console.ReadLine();
                int sum = 0;
                Dictionary<string, int> names = new Dictionary<string, int>();
                foreach (var item in data)
                {
                    if (!names.ContainsKey(item.nev))
                    {
                        names.Add(item.nev,1);
                    }
                    else
                    {
                        names[item.nev]++;
                    }
                }

                foreach (var item in data)
                {
                    if (names.ContainsKey(name) && item.nev == name)
                    {
                        sum += item.adasdb;
                    }
                }
                if (sum==0)
                {
                    Console.WriteLine("Nincs ilyen soför!");
                }
                else
                    Console.WriteLine($"{name} {sum}x használta a cb-radiót");

                StreamWriter wr = new StreamWriter("cb2.txt");
                wr.WriteLine("Kezed;Nev;AdasDb");
                foreach (var item in data)
                {
                    wr.WriteLine(AtszamolPercre(item.ora) + item.perc + ";" + item.nev + ";" + item.adasdb);
                }
                wr.Dispose();
                Console.WriteLine($"8. feladat: {names.Count}db soför");
                int highest = 0;
                string name2 = "";
                foreach (var item in names)
                {
                    if (highest< item.Value)
                    {
                        highest=item.Value;
                        name2 = item.Key;
                    }
                }
                Console.WriteLine($"9. feladat: \nNév:{name2}\t\t Adasok szama:{highest}");
            }
            else
            {
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        static int AtszamolPercre(int hour) 
        {
            return hour * 60;
        }
    }
}
