using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
	internal class Program
	{
		static void indit()
		{
            Console.WriteLine("Kérem adja meg az első számot: ");
            double szam1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a második számot: ");
            double szam2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Az elvégzendő művelet jele: ");
			string opjel = Console.ReadLine();


            if (opjel == "+")
            {
            double eredmeny = Osszeadas(szam1, szam2);
            Console.WriteLine("Az összeg: " + eredmeny);
            }
            else if (opjel == "-")
            {
                double eredmeny = Kivonas(szam1, szam2);
                Console.WriteLine("Az összeg: " + eredmeny);
            }
            else if (opjel == "/" || opjel == ":")
            {
                double eredmeny = Osztas(szam1, szam2);
                Console.WriteLine("Az összeg: " + eredmeny);
            }
            else if (opjel == "*")
            {
                double eredmeny = Szorzas(szam1, szam2);
                Console.WriteLine("Az összeg: " + eredmeny);
            }
            else if (opjel == "%")
            {
                double eredmeny = Szazalek(szam1, szam2);
                Console.WriteLine(szam1 + "-nak/-nek a(z) " + szam2 + " az " + eredmeny + " százaléka.");
            }

        }
        static double Osszeadas(double szam1, double szam2)
        {
            return szam1 + szam2;
        }
        static double Kivonas(double szam1, double szam2)
        {
            return szam1 - szam2;
        }
        static double Osztas(double szam1, double szam2)
        {
            return szam1 / szam2;
        }
        static double Szorzas(double szam1, double szam2)
        {  
            return szam1 * szam2;
        }
        static double Szazalek(double szam1, double szam2)
        {
            return szam2 / szam1 * 100;
        }

        static void Main(string[] args)
		{
			indit();
		}
	}
}
