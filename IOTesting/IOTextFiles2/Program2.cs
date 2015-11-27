using System;

namespace IOTextFiles2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			STable2 _STable2 = new STable2 ();
			IOSettings2 _io = new IOSettings2 (_STable2);

			Console.WriteLine (_STable2.stable2[0]);

			if (_io.open ())      //_iо.save ()) 
			{
				Console.WriteLine ("Таблицата е прочетена успешно");	
			} else {
				Console.WriteLine ("Таблицата НЕ е прочетена успешно");

			}
		}

		
	}
}
