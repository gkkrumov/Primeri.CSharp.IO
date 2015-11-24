
using System;

namespace IOTextFiles1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			STable1 _STable1 = new STable1 ();

			IOSettings1 _io = new IOSettings1 (_STable1);



			if (_io.open ())   //save ()) 
			{
				Console.WriteLine ("Таблицата е прочетена успешно");				
			} else {
				Console.WriteLine ("Таблицата НЕ е прочетена успешно");

			}

			Console.WriteLine (_STable1.stable1 [0]);
		}
	}
}
