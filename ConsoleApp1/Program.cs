using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            //Tanár úrat kérém hogy nézze át a feladatokat
            
            List<nobel> nobeldij = new List<nobel>();

            StreamReader streamReader = new StreamReader("nobel.csv");
            while (!streamReader.EndOfStream)
            {
                string line = Convert.ToString(streamReader.ReadLine().Split(';'));
                line.Skip(1);
                nobeldij.Add(line);
            }
            
            Console.WriteLine($"4. feladat: {nobeldij.Where(x => x  tipus == irodalom and evszam == 2017)}");

            Console.WriteLine("5. feladat: ");
            foreach (nobel adat in nobeldij)
            {
                if (adat[3] == "Curie")
                {
                    Console.WriteLine("{0}: {1} {2} ({3})", adat[0], adat[2], adat[3], adat[1]);
                }
            }
            
            Console.WriteLine("7. feladat:");
            Console.WriteLine($"fizika {nobeldij.Count(x => x == "fizika")} db");
            Console.WriteLine($"kémia           {nobeldij.Count(x => x == "kémia")} db");
            Console.WriteLine($"orvosi          {nobeldij.Count(x => x == "orvosi"}) db");
            Console.WriteLine($"irodalom            {nobeldij.Count(x => x == "irodalom"}) db");
            Console.WriteLine($"béke            {nobeldij.Count(x => x == "béke"}) db");
            Console.WriteLine($"közgazdaságtani          {nobeldij.Count(x => x == "közgazdaságtani"}) db");
            
            Console.WriteLine("8.feladat: orvosi.txt");
            streamReader sr = new streamReader("orvosi.txt");
            foreach (var item in nobeldij)
            {
                sr.write(item[0],item[2],item[3]);
            }
            */
        }
    }
}
