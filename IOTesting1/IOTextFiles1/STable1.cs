using System;

namespace IOTextFiles1
{
	public class STable1
	{
		public string[] stable1 = new string[4];
		public STable1 ()
		{
			fillSTable1 ();
		}

		private void fillSTable1 ()
		{
			stable1 [0] = "1,0,5,0.4582"; 
			stable1 [1] = "1,5,10,0.4582";
			stable1 [2] = "5,10,15,0.4582";
			stable1 [3] = "10,15,20,0.4582";
		}
	}
}

