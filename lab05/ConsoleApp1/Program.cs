﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4

{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Nimi = "Kirsi";
            employee.Salary = 50;
            Console.WriteLine(employee.Tiedot());
        }
    }
}
