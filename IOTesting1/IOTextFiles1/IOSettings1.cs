using System;

namespace IOTextFiles1
{
	public class IOSettings1
	{
		private STable1 _stable1;
		public IOSettings1 (STable1 stable1)
		{
			_stable1 = stable1;				
		}

		public bool save ()
		{
			try
			{
				string _temp = "";
				_temp = String.Join ( ";", _stable1.stable1 );

				//Запис на текстов файл
				System.IO.File.WriteAllText ( "C:\\aula\\test.txt", _temp );

				return true;
				
			}catch{				
			}

			return false;
				
		}
	}
}

