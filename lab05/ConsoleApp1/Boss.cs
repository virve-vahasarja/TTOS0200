using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4

{
    class Boss : Employee
    {
        public string Car { get; }
        public int Bonus { get; }

        public Boss(string Nimi, string Profession, string Salary, string Car, int Bonus)
           : base(Nimi, Profession, Salary);
        {
        this.Car=car;
        this.Bonus=bonus;
        }

          public override string PomonTiedot()
        {
            return Car + ", " + Bonus+", " Nimi + ", " + Profession + ", " + Salary;
        }
    }
}
