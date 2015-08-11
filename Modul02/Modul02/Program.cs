using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Дефиниране на променливи

			int a=0,b=0;
			int sum=0;
			string program_name = "Модул 2 Програма 1";
			string program_version = "1.0";

			//Данни за програма

			Console.WriteLine (program_name);
			Console.WriteLine ("Версия: " + program_version + "\n\n");

			//Събиране на числа

			a=5;
			b = 6;
			sum = a + b;

			//Писане в конзола

			Console.Write(a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine (sum);

			//Допълнителни оператори

			Console.WriteLine("\nИзползване на +=");
			a += b;
			Console.WriteLine(a);

			Console.WriteLine("\nИзползване на -=");
			a -= b;
			Console.WriteLine(a);

			Console.WriteLine("\nИзползване на *=");
			a *= b;
			Console.WriteLine(a);

			Console.WriteLine("\nИзползване на ++");
			a ++;
			Console.WriteLine(a);

			Console.WriteLine("\nСтандартно деление");
			Console.WriteLine(a / b);

			Console.WriteLine("\nПолучаване на остатък");
			Console.WriteLine(a % b);
		}
	}
}
