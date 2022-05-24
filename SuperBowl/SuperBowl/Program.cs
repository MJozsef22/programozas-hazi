using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowl
{
    internal class Program
    {
        static List<Read> data = new List<Read>();
        static void Main(string[] args)
        {
            if (File.Exists("SuperBowl.txt"))
            {
                string[] temp = File.ReadAllLines("SuperBowl.txt");
                foreach (string line in temp.Skip(1))
                    data.Add(new Read(line));

                Console.WriteLine($"4.feladat:{data.Count}db");
                List<double> eredmeny1 = new List<double>();
                List<double> gyoztes = new List<double>();
                List<double> vesztes = new List<double>();

                foreach (var item in data)
                {
                    string[] splitedData = item.eredmeny.Split('-');
                    gyoztes.Add(int.Parse(splitedData[0]));
                    vesztes.Add(int.Parse(splitedData[1]));
                    eredmeny1.Add(int.Parse(splitedData[0]) - int.Parse(splitedData[1]));
                }
                //Console.WriteLine(String.Join(",",eredmeny1));
                double osszes = 0;
                foreach (var item in eredmeny1)
                {
                    osszes += item;
                }

                double average = Math.Round((osszes / data.Count), 1);
                Console.WriteLine($"5.feladat: {average}");
                int max = int.MinValue;
                int srszam = 0;
                int srszamVegleges = 0;
                foreach (var item in data)
                {
                    srszam++;
                    if (max < item.nezok)
                    {
                        max = item.nezok;
                        srszamVegleges = srszam;
                    }
                }
                List<RomaiSorszam> sorszam = new List<RomaiSorszam>();
                List<string> sorszam2 = new List<string>();
                foreach (var item in data)
                {
                    sorszam.Add(new RomaiSorszam(item.sorszam));
                }
                foreach (var item in sorszam)
                {
                    sorszam2.Add(item.ArabSsz);
                }
                foreach (var item in data)
                {
                    if (item.nezok == max)
                    {
                        Console.WriteLine($"6.feladat :\n"
                            + $"Sorszam(dátum): {srszamVegleges} ({item.datum})\n"
                            + $"Győztes csapat: {item.gyoztes}, szerzett pontok: {gyoztes[srszamVegleges-1]}\n"
                            + $"Vesztes csapat: {item.vesztes}, szerzett pontok: {vesztes[srszamVegleges-1]}\n"
                            + $"Helyszín: {item.helyszin}\n"
                            + $"Város, Állam: {item.Varos_Allam}\n"
                            + $"Nezőszám: {max}");
                    }
                }
            }
            else
            {
                Console.WriteLine("A fájl nem található!");
            }
            Console.ReadKey();
        }
    }
}
