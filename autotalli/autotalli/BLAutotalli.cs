using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
   public static class Autotalli
    {
        public static List<Auto> HaeAutot()
        {
            List<Auto> autot = new List<Auto>();
            //gui testaamista varten keksitään muutama auto
            Auto a = new Auto();
            a.Merkki = "Volvo";
            a.Malli = "V70";
            a.VM = 1970;
            a.KM = 400000;
            a.Hinta = 9000F;
            a.URL = "VolvoV70.png";
            autot.Add(a);

            //toinenkin auto
            Auto b = new Auto()
            {
                Merkki = "Audi", Malli = "A4", VM = 2010, KM = 100000, Hinta = 50, URL = "AudiA4.png"
            };
            autot.Add(b);
             
         

            //toinenkin auto
            Auto c = new Auto()
            {
                Merkki = "Audi",
                Malli = "A3",
                VM = 2000,
                KM = 100000,
                Hinta = 50
            };
            autot.Add(c);

            //neljäs auto
            Auto d = new Auto()
            {
                Merkki = "Lada",
                Malli = "Samara",
                VM = 1989,
                KM = 100000,
                Hinta = 50,
                URL="samara.jpg"
            };
            autot.Add(d);

            //palautus
            return autot;
        }
    }
    public class Auto
    {
        public string Merkki { get; set;  }
        public string Malli { get; set; }
        public int VM { get; set; }
        public int KM { get; set; }
        public float Hinta { get; set; }
        public string URL { get; set; }
    }
}
