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
				_temp = String.Join ( "\r\n", _stable1.stable1 );

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
			{	string _temp = System.IO.File.ReadAllText (getPath () );

				string[] _table1 = _temp.Replace("\r", "").Split('\n');

				for ( int i = 0; i < _table1.Length; i++ )
				{
					_stable1.stable1[i] = _table1[i];
					
				}				

				return true;				
				
			}catch{				
			}

			return false;
						
		}
	}
}

