using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classBeadando
{
    internal class Program
    {
        static List<FileRead> list = new List<FileRead>();
        static void Main(string[] args)
        {
            string path = "nevek.txt";
            if (File.Exists(path))
            {
                string[] temp = File.ReadAllLines(path);
                foreach (var item in temp)
                {
                    FileRead data = new FileRead(item);
                    list.Add(data);
                }
                Console.WriteLine("\n Kinek van a leghosszabb vezetékneve?");
                string leghosszabb = string.Empty;
                foreach (var item in list)
                {
                    if (item.vezeteknev.Length > leghosszabb.Length)
                    {
                        leghosszabb = item.vezeteknev;
                    }
                }
                Console.WriteLine("\n   A leghosszabb vezetéknév: {0}", leghosszabb);


                Console.WriteLine("\n   Kinek van két keresztneve?");
                foreach (var item in list)
                {
                    if (item.masodikKeresztnev.Length > 1)
                    {
                        Console.WriteLine("===================================");
                        Console.WriteLine("   {0} {1} {2}", item.vezeteknev, item.keresztnev, item.masodikKeresztnev);
                        Console.WriteLine("===================================");
                    }
                }

                leghosszabb = string.Empty;
                int count = 0;
                int i = 0;
                foreach (var item in list)
                {
                    i++;
                    if (item.vezeteknev.Length + item.keresztnev.Length + item.masodikKeresztnev.Length > leghosszabb.Length)
                    {
                        leghosszabb = item.vezeteknev + item.keresztnev  + item.masodikKeresztnev;
                        count = i;
                    }
                }
                Console.WriteLine("\n   Hányadik a leghosszabb név a fájlban?: {0} ({1})", count,leghosszabb);
                
                
            }
            else
            {
                Console.WriteLine("\n   A fájl nem található!");
            }

            Console.ReadKey();
        }

    }
}
