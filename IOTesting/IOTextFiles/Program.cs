using System;

namespace IOTextFiles
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			STable _STable = new STable ();
			IOSettings _io = new IOSettings (_STable);

			Console.WriteLine (_STable.stable[0]);

			if (_io.open ())      //_iо.save ()) 
			{
				Console.WriteLine ("Таблицата е прочетена успешно");	
			} else {
				Console.WriteLine ("Таблицата НЕ е прочетена успешно");
				
			}
		}

	}
}





			//
//			IOSettings _io = new IOSettings (_STable);
//
//
//
//			if (_io.open ())   //save ()) 
//			{
//								
//			} else {
//				
//
//			}
//
//			Console.WriteLine (_STable.stable [2]);

		