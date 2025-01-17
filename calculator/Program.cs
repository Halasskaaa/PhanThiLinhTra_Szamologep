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
			int elso = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Kérem adja meg a második számot: ");
			int masodik = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Az elvégzendő művelet jele: ");
			string opjel = Console.ReadLine();
        }
		static void Main(string[] args)
		{
			indit();
		}
	}
}
