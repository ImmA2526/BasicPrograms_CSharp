//Day 1: Power of Number
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class PowerofNumber
    {
		public static void Power()
		{
			int Number, Number2, Result;
			Console.Write("Enter Number :  ");   //WriteLine take cursor on new line Write >>>> Take Cursor on same 
			Number = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter Power :  ");
			Number2 = Convert.ToInt32(Console.ReadLine());

			Result = (int)Math.Pow(Number, Number2);
			Console.WriteLine("The Power of :  " + Number + " is " + Result+ "\n"  );
		}

	}
}
