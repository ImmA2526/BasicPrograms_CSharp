//Day:2 Guess The Number

using System;
using System.Collections.Generic;
using System.Text;
namespace BasicProgram
{
    class GuessNumber
    {
		public static void GuesNumber()
		{
			int Input;
			Random Number = new Random();
			int Number1 = Number.Next(1,11);
			while (true)
			{
				Console.WriteLine("Enter Number :  ");
				Input = Convert.ToInt32(Console.ReadLine());
				if (Number1 == Input)
				{
					Console.WriteLine("The User input Number is  " + Input + "  and Random Number  " + Number1 +  " Ur Guess is Right ");
					break;
				}
				else if (Input > Number1)
				{
					Console.WriteLine("The Input Number is Greater Than The Random Number");
				}
				else
				{
					Console.WriteLine("The Input Number is Smaller Than The Random Number");
				}
			}//while
		}//method
	}//class
}//namespace
