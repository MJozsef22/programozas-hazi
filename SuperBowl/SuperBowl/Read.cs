using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowl
{
    internal class Read
    {
        public string sorszam { get; private set; }
        public string datum { get; private set; }
        public string gyoztes { get; private set; }
        public string eredmeny{ get; private set; }
        public string vesztes { get; private set; }
        public string helyszin { get; private set; }
        public string Varos_Allam { get; private set; }
        public int nezok { get; private set; }

        public Read(string line)
        {
            string[] temp = line.Split(';');
            sorszam = temp[0];
            datum = temp[1];
            gyoztes = temp[2];
            eredmeny = temp[3];
            vesztes = temp[4];
            helyszin = temp[5];
            Varos_Allam = temp[6];
            nezok = int.Parse(temp[7]);
        }
    }
}
