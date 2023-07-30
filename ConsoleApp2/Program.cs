using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double höheSchild = 10;
            double breiteSchild = 10;
            double längeSchild = 100;
            double gurtmass = 300;

            Console.WriteLine("Die Anzahl der Schilder: " + findeHoehe(höheSchild, breiteSchild, längeSchild, gurtmass));
            Console.ReadKey();

        }

        public static int findeHoehe(double höheSchild, double breiteSchild, double längeSchild, double gurtmass)
        {
            int anzahl = 0;
            double höheKarton = 0;

            höheKarton = (gurtmass - längeSchild - 2 * breiteSchild) / 2;

            anzahl = (int)(höheKarton / höheSchild);


            return anzahl;
        }
    }
}
