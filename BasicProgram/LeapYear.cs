//Day 1: Leap Year
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class LeapYear
    {
		public static void LepYear()
		{
			while (true)
			{
				Console.WriteLine("Enter Year: \t");
				int Year = Convert.ToInt32(Console.ReadLine());

				if (Year % 4 == 0)
				{
					Console.WriteLine("Leap Year");
					break;
				}
				else
				{
					Console.WriteLine("Not Leap");
					//break;
				}

			}//Console.WriteLine("Hello World!");
		}

	}
}
