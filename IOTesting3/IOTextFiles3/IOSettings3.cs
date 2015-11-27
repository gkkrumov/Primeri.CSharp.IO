using System;

namespace IOTextFiles3
{
	public class IOSettings3
	{
		private STable3 _stable3;
		public IOSettings3 (STable3 stable3)
		{
			_stable3 = stable3;
		}

		public string getPath ()
		{
			//Програма\\Settings\\Settings.txt
			string _path = System.IO.Path.Combine ( AppDomain.CurrentDomain.BaseDirectory, "Settings");
			_path = System.IO.Path.Combine (_path, "settings.txt3");

			//Други видове директории
			//string _user = Environment.GetFolderPath (Environment.SpecialFolder.LocalApplicationData);
			//Console.WriteLine (_user);

			//string _desktop = Environment.GetFolderPath (Environment.SpecialFolder.Desktop);
			//Console.WriteLine (_desktop);

			return _path;
		}
		public bool save ()

		{
			try
			{
				string _temp = "";

				_temp = String.Join ( "\r\n", _stable3.stable3 );

				//Запис на текстов файл
				System.IO.File.WriteAllText ( getPath (), _temp );

				return true;
				
			}catch{
			}

			return false;
		}

		public bool open ()
		{
			try {

				iniSettings ();

				string _temp = "", _filePath = getPath ();

				if ( System.IO.File.Exists ( _filePath ))  //Проверка дали пътят е валиден					
				{
					System.IO.File.ReadAllText ( _filePath );

					string[] _table3 = _temp.Replace("\r", "").Split ('\n');

					for (int i = 0; i < _table3.Length; i++) 
					{
						_stable3.stable3[i] = _table3[i];
					}
				}else{
					
					return false;
				}

				System.Diagnostics.Process.Start ( _filePath );

					return true;
			} catch {
			}
			return false;
		}

		private void iniSettings ()
		{
			try{
				
				bool _fileExist = System.IO.File.Exists( getPath () );

				if  ( !_fileExist )
				{
					string _directory = System.IO.Path.GetDirectoryName( getPath () );

					//Застраховаме се, че директорията съществува 
					if ( !System.IO.Directory.Exists ( _directory) )
					{
						System.IO.Directory.CreateDirectory ( _directory );
					}

					//Запаметяваме съдържанието на файла
					save ();
				}				
			}catch{	
			}
		}

	}
}





//		
//		{
//			string _path = System.IO.Path.Combine ( AppDomain.CurrentDomain.BaseDirectory, "test.txt" );
			//return _puth;
	//		}
	//		public bool save ()
	//	{
//			try
//			{
//				
//				
//
//				
//				 ( getPath (), _temp );
//
//				return true;				
//			}catch{				
//			}
//			return false;
//
//		}
//
//		public bool open ()
//		{
//			try
//			{
//				string _temp = System.IO.File.ReadAllText ( getPath ());
//
//				string[] _table3 = _temp.Replace ("\r", "").Split ('\n');
//
//				for ( int i = 0; i < _table3.Length; i++)
//				{
//					_stable3.stable3 [i] = _table3 [i];
//				}
//
//				return true;				
//			}catch{
//			}
//			return false;
//
//		}

	
