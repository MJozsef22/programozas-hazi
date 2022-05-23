using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbradio
{
    internal class Read
    {
        public int ora { get; private set; }
        public int perc { get; private set; }
        public int adasdb { get; private set; }
        public string nev { get; private set; }
        public Read(string line)
        {
            string[] temp = line.Split(';');
            ora = int.Parse(temp[0]);
            perc = int.Parse(temp[1]);
            adasdb = int.Parse(temp[2]);
            nev = temp[3];
        }
    }
}
