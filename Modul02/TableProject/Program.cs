using System;

namespace TableProject
{
	class MainClass
	{
		enum ti{ime=0,Familiq,Godini};
		public static void Main (string[] args)
		{
			// Definirane na tablica		
			string[,] table = new string[3, 3];

			//Definirane na purvi red
			table[0,(int)ti.ime]="Ivan";table[0,(int)ti.Familiq]="Petrov";table[0,(int)ti.Godini]="28";

			//Definirane na vtori red
			table[1,(int)ti.ime]="Simeon";table[1,(int)ti.Familiq]="Ivanov";table[1,(int)ti.Godini]="25";

			//Pechat
			Console.Write("Koi red iskate da vidite:");
			int ind = Convert.ToInt32 (Console.ReadLine ())-1;
			Console.WriteLine ((table [ind,(int) ti.ime]) [0] + ". " + table [ind,(int) ti.Familiq] + ", " + table [ind,(int) ti.Godini]);

		}
	}
}
//			string[] row = new string[3];
//			row [0] = "Ред 1";
//			row [1] = "Ред 2";
//			row [2] = "Ред 3";
//			Console.WriteLine ("Масив Row: " + row [0] + "," + row [1] + "," + row [2] + "\n");
//
//			string[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
//			Console.WriteLine ("Броят на елементите на масива са:\n" + "1,2,3,4,5,6,7,8,9\n\ne:" + parse.Length);
//			string list1 = string.Join (";", parse);
//			Console.WriteLine ("Новият стринг е:\n\n" + list1 + "\n\n");