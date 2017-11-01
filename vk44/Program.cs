using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{

    class Program
    {
        static void LueOhjastajatVer1()
        {
            try
            {
                //luetaan tiedosto läpi rivi kerrallaan
                int counter = 0;
                string line;
                System.IO.StreamReader stream = new System.IO.StreamReader(@"d:\H4143\TTOS0200\tilasto2017.txt");
                while ((line=stream.ReadLine()) != null)
                    {
                    Console.WriteLine(counter + ":" + line);
                    counter++;
                }
                stream.Close(); //suljetaan striimi ja tiedosto
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                LueOhjastajatVer1();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
