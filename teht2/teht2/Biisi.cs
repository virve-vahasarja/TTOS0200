using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    public class Biisi
    {
        public string Nimi { get; set; }
        public int Kesto { get; set; }

        public Biisi(string nimi, int kesto)
        {
            Nimi = nimi;
            Kesto = kesto;

          
        }
        public override string ToString()
        {
            return "-"+Nimi+", "+Kesto;
        }
    }
}
