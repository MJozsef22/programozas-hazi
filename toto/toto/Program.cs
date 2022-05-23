using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toto
{
    internal class Program
    {
         static List<EredmenyElemzo> Datas = new List<EredmenyElemzo>();
        static void Main(string[] args)
        {
            string path = "toto.txt";
            if (File.Exists(path))
            {

                string[] temp = File.ReadAllLines(path);
                foreach (var item in temp.Skip(1))
                {
                    EredmenyElemzo data = new EredmenyElemzo(item);
                    Datas.Add(data);
                }

                Console.WriteLine($"Összes forduló száma: {Datas.Count}");

                int telitalatok = 0;
                foreach (var item in Datas)
                {
                    telitalatok += item.T13p1;
                }

                Console.WriteLine($"Telitalálatos szelvények száma: {telitalatok}");


            }
            else
            {
                Console.WriteLine("A fájl nem található!");
            }
            Console.ReadKey();
        }
    }

    class EredmenyElemzo
    {
        public int ev { get; private set; }
        public int het { get; private set; }
        public int fordulo { get; private set; }
        public int T13p1 { get; private set; }
        public int Ny13p1 { get; private set; }
        public string eredmenyek { get; private set; }

        public EredmenyElemzo(string line) 
        {
            string[] data = line.Split(';');
            ev = int.Parse(data[0]);
            het = int.Parse(data[1]);
            fordulo = int.Parse(data[2]);
            T13p1 = int.Parse(data[3]);
            Ny13p1 = int.Parse(data[4]);
            eredmenyek = data[5];

        }
        private int DontetlenekSzama
        {
            get
            {
                return Megszamol('X');
            }
        }

        private int Megszamol(char kimenet)
        {
            int darab = 0;
            foreach (var i in eredmenyek)
            {
                if (i == kimenet) darab++;
            }
            return darab;
        }

        public bool NemvoltDontetlenMerkozes
        {
            get
            {
                return DontetlenekSzama == 0;
            }
        }

    }
}
