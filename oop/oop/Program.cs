using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static List<NapiMunka> data = new List<NapiMunka>();


        static void Main(string[] args)
        {
            string path = "diszek.txt";
            if (File.Exists(path))
            {
                string[] temp = File.ReadAllLines(path);
                foreach (var item in temp)
                {
                    NapiMunka adat = new NapiMunka(item);
                    data.Add(adat);
                }

                Console.WriteLine($"Összesen elkészített: {NapiMunka.KeszultDb} db");

                foreach (var item in data)
                {
                    if (item.AngyalkaKesz + item.FenyofaKesz + item.HarangKesz == 0)
                    {
                        Console.WriteLine("\nVolt olyan nap amikor nem készített semmit!");
                    }
                    else if (item.AngyalkaKesz + item.FenyofaKesz + item.HarangKesz > 0)
                    {
                        Console.WriteLine("\nNem volt olyan nap amikor nem készült semmi!");
                        break;
                    }
                }
                try
                {

                    int num = 0;
                    do
                    {

                        Console.Write("\nAdj meg egy számok 1-40 között(számmal): ");
                        int.TryParse(Console.ReadLine(), out num);



                    } while (num < 1 || num > 40);
                    int counter = 0;
                    int angyalka = 0;
                    int harang = 0;
                    int fenyofa = 0;
                    foreach (var item in data)
                    {
                        counter++;
                        if (num >= counter)
                        {
                            angyalka += item.AngyalkaKesz + item.AngyalkaEladott;
                            harang += item.HarangKesz + item.HarangEladott;
                            fenyofa += item.FenyofaKesz + item.FenyofaEladott;
                            
                        }
                    }

                    Console.WriteLine($"{num}. napon:\nAngyalka: {angyalka}\nHarang:{harang}\nFenyőfa:{fenyofa}");

                    int ffa = 0;
                    int angy = 0;
                    int har = 0;
                    foreach (var item in data)
                    {
                        ffa += -(item.FenyofaEladott);
                        angy += -(item.AngyalkaEladott);
                        har += -(item.HarangEladott);
                    }
                    int highest = 0;
                    if (har >=ffa && har>=angy)
                    {
                        highest = har;
                    }
                    else if (ffa >= angy && ffa>= har)
                    {
                        highest = ffa;
                    }
                    else
                    {
                        highest = angy;
                    }

                    Console.WriteLine($"A legtöbbet eladótt dísz: {highest}db");
                    Console.WriteLine("Díszek:");
                    if (ffa == highest)
                    {
                        Console.WriteLine("Fenyőfa dísz");
                    }
                    if (angy == highest)
                    {
                        Console.WriteLine("Angyal dísz");
                    }
                    if (har == highest)
                    {
                        Console.WriteLine("Harang dísz");
                    }

                    StreamWriter write = new StreamWriter("bevetel.txt");

                    int db = 0;
                    foreach (var item in data)
                    {
                        if (item.NapiBevetel() > 10000)
                        {
                            db++;
                            write.WriteLine($"{item.Nap}. {item.NapiBevetel()}Ft;");
                        }
                    }
                    write.WriteLine($"\n{db} napon volt legalább 10000Ft a bevétel.");
                    write.Dispose();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Hibás a karaktert adtál meg!");

                }
                catch (Exception)
                {
                    Console.WriteLine("Kérlek futtasd újra a programot!");
                }
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("A programban megadott fájl nem található!");
            }
        }
    }
    class NapiMunka
    {
        public static int KeszultDb { get; private set; }
        public int Nap { get; private set; }
        public int HarangKesz { get; private set; }
        public int HarangEladott { get; private set; }
        public int AngyalkaKesz { get; private set; }
        public int AngyalkaEladott { get; private set; }
        public int FenyofaKesz { get; private set; }
        public int FenyofaEladott { get; private set; }

        public NapiMunka(string sor)
        {
            string[] s = sor.Split(';');
            Nap = Convert.ToInt32(s[0]);
            HarangKesz = Convert.ToInt32(s[1]);
            HarangEladott = Convert.ToInt32(s[2]);
            AngyalkaKesz = Convert.ToInt32(s[3]);
            AngyalkaEladott = Convert.ToInt32(s[4]);
            FenyofaKesz = Convert.ToInt32(s[5]);
            FenyofaEladott = Convert.ToInt32(s[6]);

            NapiMunka.KeszultDb += HarangKesz + AngyalkaKesz + FenyofaKesz;
        }

        public int NapiBevetel()
        {
            return -(HarangEladott * 1000 + AngyalkaEladott * 1350 + FenyofaEladott * 1500);
        }
    }
}
