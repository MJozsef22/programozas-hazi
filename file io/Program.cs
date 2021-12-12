using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file_io
{
    class Program
    {
        static List<FileRead> list = new List<FileRead>();

        static void Main(string[] args)
        {
            

            string path = "datas.txt";
            if (File.Exists(path))
            {
                string[] temp = File.ReadAllLines(path);
                foreach (string sor in temp)
                {
                    FileRead data = new FileRead(sor);
                    list.Add(data);
                }

                kiiras();
            }
            else
            {
                Console.WriteLine("A megadaott fájl nem találjóható a mappájában!");
            }

            Console.ReadLine();
        }

        static void kiiras()
        {
            foreach (var item in list)
            {

                Console.WriteLine("===============================");
                Console.WriteLine("Név: {0}", item.nev);
                Console.WriteLine("Dátum: {0} ", item.datum);
                Console.WriteLine("Város: {0} ", item.varos);
                Console.WriteLine("Életkor: {0} ", item.eletkor);
                Console.WriteLine("Anyja neve: {0} ", item.anyjaNeve);
                Console.WriteLine("===============================");
            }
        }
    }
}
