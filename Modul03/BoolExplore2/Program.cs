using System;

namespace BoolExplore2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] _i = new int[]{ 4, 3, 2 };
			int _ui = 0;//Convert.ToInt32 (Console.ReadLine ());
			string _input="0";

			Console.WriteLine ("Моля въведете индекс");
			_input = Console.ReadLine ();

			bool _check01=int.TryParse(_input,out _ui);

			try{
				Console.Write("Елемент "+_ui.ToString()+" от масива е:");
				Console.WriteLine(_i[_ui-1]);
			}
			catch{
				Console.WriteLine("Недефиниран елемент");
			}


			// Използване на условно присвояване
//			_ui=(_ui<=_i.Length)? _ui :3;
//			_ui=(_ui>0)?_ui :1;


			//Използване на switch
//			switch(_ui){
//			case 1:
//				{
//					Console.Write ("Първи елемент на масива: ");
//					Console.WriteLine (_i [_ui - 1]);
//					break;
//				}
//			case 2:
//				{
//					Console.Write ("Втори елемент на масива: ");
//					Console.WriteLine (_i [_ui - 1]);
//					break;
//				}
//			case 3:
//				{
//					Console.Write ("Трети елемент на масива: ");
//					Console.WriteLine (_i [_ui - 1]);
//					break;
//				}
//			default:
//				{
//					Console.Write ("Масивът няма елемент за тази стойност\n\n");
//					break;
//				}
//
//
//			if (_check01) {
//				Console.WriteLine (_i [_ui - 1]);
//			}
		}
	}
	}

