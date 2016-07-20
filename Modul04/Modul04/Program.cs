using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,] _table = {
				{"Иван", 	"Петъров", 	"13" },
				{"Петър", 	"Георгиев", "17" },
				{"Ганчо", 	"Петров", 	"20" },
				{"Сашо", 	"Миленов", 	"13" },
				{"Мишо", 	"Ковачев", 	"18" },
				{"Тити", 	"Димов", 	"15" },
				{"Митко", 	"Тончев", 	"22" },
			};

			Console.WriteLine ("Име".PadRight(12) + "Фамилия".PadRight(12)+"Години".PadRight(12));
			Console.WriteLine ("=================================================");

			//Пример с FOR
			//			for (int i=0;i<_table.Length/3;i++)
			//			{
			//				for (int j = 0; j < 3; j++) 
			//				{
			//					Console.Write (_table [i, j].PadRight(12));
			//				}
			//				Console.WriteLine();
			//				//код на цикъла
			//				//Console.WriteLine (_table[i]);
			//
			//			}
			// Пример с While
			//int i=0;
			//while(i<_table.Length /3)
			//{

			//	Console.WriteLine(_table[i,0].PadRight(12) + _table[i,1].PadRight(12)+_table[i,2].PadRight(12));
			//	i++;

			//Пример с Do While
			int i = 0;
			do
			{
				//Код
					Console.WriteLine(_table[i,0].PadRight(12) + _table[i,1].PadRight(12)+_table[i,2].PadRight(12));
				i++
			} while (i < _table.Length/3);
		}
		
	}
}
}
