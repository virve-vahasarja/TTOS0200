using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    public class Kortti
    {
        public string Maa { get; set; }
        public int Numero { get; set; }

        public Kortti(string maa, int numero)
        {
            Maa = maa;
            Numero = numero;
        }
        public override string ToString()
        {
            return Maa +" "+ Numero;
        }
    }
}
