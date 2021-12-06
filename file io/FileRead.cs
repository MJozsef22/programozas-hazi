using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_io
{
    class FileRead
    {
        public string nev { get; private set; }
        public string datum { get; private set; }
        public string varos { get; private set; }
        public string eletkor { get; private set; }
        public string anyjaNeve { get; private set; }

        public FileRead(string line)
        {
            string[] datas = line.Split(';');
            nev = datas[0];
            datum = datas[1];
            varos = datas[2];
            eletkor = datas[3];
            anyjaNeve = datas[4];
        }
        
    }
}
