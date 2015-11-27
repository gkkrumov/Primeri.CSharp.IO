using System;

namespace IOTextFiles3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			STable3 _STable3 = new STable3 ();
			IOSettings3 _io = new IOSettings3 (_STable3);



			if (_io.open ()) {    //_iо.save ())
				Console.WriteLine ("Таблицата е прочетена успешно");
			} else {
				Console.WriteLine ("Таблицата НЕ е прочетена успешно");
			}
			Console.WriteLine (_STable3.stable3[1]);

		}

	}
}



//		
//		
//
//		
//
//		 
//		{
//				
//		} else {
//			Console.WriteLine ("Таблицата НЕ е прочетена успешно");
//
//		}
