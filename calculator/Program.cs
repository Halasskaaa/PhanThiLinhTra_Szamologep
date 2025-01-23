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

            double eredmeny = Osszeadas(szam1, szam2);

            Console.WriteLine("Az összeg: " + eredmeny);
        }
        static double Osszeadas(double szam1, double szam2)
        {
            return szam1 + szam2;
        }

        static void Main(string[] args)
		{
			indit();
		}
	}
}
