using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theThing
{
    class Thing
    {
        //julkineen jäsenmuuttuja, ei ominaisuus
        //    public string Name;

        //parempi vaihtoehto, ominaisuus AutoImplemented Propertyn avulla
        //public string Name { get; set; }
        //ToString -metodi käyttää jäsenmuuttujaa tai propertyä
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //konstruktorit {
        name= "nobody here";
            }
        public override string ToString()
        {
        return "nimeni on: "+ Name;
            //mutta mieluummin jos on sisäinen muuttuja niin käytetään sitä
            return "nimeni on " + name;
            }

    }
    class Program
    {
        static void Main(string[] args)
        {/*se jostakin-testaus
            Thing t = new Thing();
            t.Name = "jotakin";
            Console.WriteLine(t.Name);
        Console.WriteLine(t.ToString()); */

        //student-olion testaus
        Student s = new Student();
        s.FirstName = "esa";
        s.LastName = "kk";
        Student s2 = new Student("Jaska", "Jokunen");

        //luodaan kokoelma student-olioita, käytetään List
        List<Student> students = new List<Student>();
        students.Add(s);
        students.Add(s2);
        students.Add(new Student("Arska", "Aaltonen"));
        //näytetään oppilaat
        Console.WriteLine("luokan oppilaat: ");
        foreach (Student item in students)
        {
            Console.WriteLine(item.ToString());
        }

        //restataan group loukka
        IGrouping luokka = new IGrouping();
        luokka.Name = "ddd";
        luokka.Student.Add(new Student("anna", "auronko"));
        Console.WriteLine(luokka.ToString());
    }
    }
}
