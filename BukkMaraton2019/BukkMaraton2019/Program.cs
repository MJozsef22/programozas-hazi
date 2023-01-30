using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BukkMaraton2019
{
    
    internal class Program
    {
        class versenyzo
        {
            public string rajtszam { get; private set; }
            public string kategoria { get; private set; }
            public string nev { get; private set; }
            public string egyesulet { get; private set; }
            public string ido { get; private set; }
            public int ora { get; private set; }
            public int perc { get; private set; }
            public int mp { get; private set; }
            public DateTime eredmeny { get; private set; }
            public versenyzo(string sr)
            {
                string[] temp = sr.Split(';');
                rajtszam = temp[0];
                kategoria = temp[1];
                nev = temp[2];
                egyesulet = temp[3];
                ido = temp[4];
                ora = int.Parse(ido.Split(':')[0]);
                perc = int.Parse(ido.Split(':')[1]);
                mp = int.Parse(ido.Split(':')[2]);
                eredmeny = new DateTime(2019, 8, 4,ora,perc,mp);
            }
        }

        static void Main(string[] args)
        {
            List<versenyzo> data = new List<versenyzo>();
            string path = "bukkm2019.txt";
            foreach (var item in File.ReadAllLines(path).Skip(1))
            {
                data.Add(new versenyzo(item));
            }

            Console.WriteLine($"A versenyt {Math.Round(100-(data.Count * 1.0 / 691)*100, 2)} arányban teljesítették.");

            int sum = 0;
            foreach (var item in data)
            {
                if (item.rajtszam[0] == 'R')
                {
                    if (item.kategoria[item.kategoria.Length - 1] =='n')
                    {
                        sum++;
                    }
                }
            }

            bool volt_e = false;
            foreach (var item in data)
            {
                if (item.ido[0] >='6')
                {
                    Console.WriteLine("Volt ilyen versenyző!");
                    volt_e = true;
                    break;
                }
            }
            if (volt_e == false)
                Console.WriteLine("Nemm volt ilyen versenyző!");

            versenyzo gyoztes = null;
            DateTime legkisebbido = new DateTime(2019,8,4,23,59,59);
            foreach (var item in data)
            {
                if (item.eredmeny < legkisebbido && item.kategoria == "ff" && item.rajtszam[0] =='')
                {

                }
            }
            Console.ReadKey();

        }
    }
}
