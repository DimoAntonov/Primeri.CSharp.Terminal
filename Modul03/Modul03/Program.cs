using System;

namespace Modul03
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double a = 0, b = 0, c = 0;

			Console.Write ("> a = ");a = Convert.ToDouble (Console.ReadLine ());
			Console.Write ("> b = ");b = Convert.ToDouble (Console.ReadLine ());

			//Formatirane
			string form = "#0.00 m3";
		

			//Stepenuvane
			c=Math.Pow(a,b);
			Console.WriteLine ("\n\n> a ^ b ="+ c.ToString(form));

			//Korenuvane
			c=Math.Sqrt(b);
			Console.WriteLine ("\n\n> b ^ 1/2 ="+ c.ToString(form));

			//Zakruglenie
			c=Math.Round(a/b);
			Console.WriteLine ("\n\n> a / b ="+ c.ToString(form));
		}
	}
}
