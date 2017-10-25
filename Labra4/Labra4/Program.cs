using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12;
            bool kkkk = Teht1.OnkoLuku (number);


            // ask number from the user (read one line)
            Console.Write("Give a number > ");
            string syote = Console.ReadLine();
            // try to read number from the given line
            int number;
            bool result = int.TryParse(syote, out number);
            // number (integer) was given correctly, use it..
            if (result)
            {
                Console.WriteLine("Number was " + number);
            }


        }
    }
}
