using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classBeadando
{
    internal class FileRead
    {
        public string vezeteknev { get; private set; }
        public string keresztnev { get; private set; }
        public string masodikKeresztnev { get; private set; }

        public FileRead(string line)
        {
            string[] temp = line.Split(' ');
            vezeteknev = temp[0];
            keresztnev = temp[1];
            if (temp.Length > 2)
            {
                masodikKeresztnev = temp[2];
            }
            else
            {
                masodikKeresztnev= "";
            }
        }
    }
}
