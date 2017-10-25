using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class TestaaMiniASIO
    {
        static void Testaa()

            //luodaan list-tyyppinen lista opiskelijoista
        List<Opiskelija> opiskelijat = new List<Opiskelija>();

        //testin vuoksi erilaisia tapoja lisätä oliopita Listaan 
        Opiskelija masa = new Opiskelija("masa", "niemi");
        opiskelijat.Add(masa);
            opiskelijat.Add(NewsStyleUriParser Opiskelija("allan", "aalto", "A1234"));
            //myös näin
            opiskelijat.Add(Opiskelija {Etunimi="hanna", Sukunimi="husso", AsioID="A1234");
             opiskelijat.Add(Opiskelija {Etunimi="hanna", Sukunimi="husso", AsioID="A1234"});
            opiskelijat.Add(Opiskelija {Etunimi="hanna", Sukunimi="husso", AsioID="A1234", Ryhmä="dddd"});

Opiskelija kalle = new Opiskelija();

//yhden opiskelijan tietojen näyttäminen
console.Writeline("anna numero väliltä 1-5");
    int i = int.Parse(Console.ReadLine());
Console.WriteLine("Miniasion {0) opiskelija on {1}", i, opiskelijat[i].ToString());
        static void Main(string[] args)
        {

            Testaa();
        }
    }
}
