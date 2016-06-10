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
			for (int i=0;i<_table.Length/3;i++)
			{
				for (int j = 0; j < 3; j++) 
				{
					Console.Write (_table [i, j].PadRight(12));
				}
				Console.WriteLine();
				//код на цикъла
				//Console.WriteLine (_table[i]);
			}
		}
	}
}
