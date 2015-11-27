using System;

namespace IOTextFiles2
{
	public class IOSettings2
	{
		private STable2 _stable2;
		public IOSettings2 (STable2 stable2)
		{
			_stable2 = stable2;
		}

		public string getPath ()
		{
			string _path = System.IO.Path.Combine ( AppDomain.CurrentDomain.BaseDirectory, "test.txt" );
			return _path;
		}
		public bool save ()
		{
			try
			{
				string _temp = "";
				_temp = String.Join ( ";", _stable2.stable2 );

				//Запис на текстов файл
				System.IO.File.WriteAllText ( getPath (), _temp );

				return true;				
			}catch{				
			}
			return false;

		}

		public bool open ()
		{
			try
			{
				string _temp = System.IO.File.ReadAllText ( getPath ());

				string[] _table2 = _temp.Replace ("\r", "").Split ('\n');

				for ( int i = 0; i < _table2.Length; i++)
				{
					_stable2.stable2 [i] = _table2 [i];
				}

				return true;				
			}catch{
			}
			return false;

		}

	}
}

