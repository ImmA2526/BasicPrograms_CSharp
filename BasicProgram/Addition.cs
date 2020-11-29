//Day1: Addition of Two Number 
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class Addition
    {
		public static void Adition()
		{
			int a = 0, b = 0, Sum;
			Console.WriteLine("Enter 1st Number: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter 2nd Number");
			b = Convert.ToInt32(Console.ReadLine());
			Sum = a + b;
			Console.WriteLine("Addition is : " + Sum);
		}
	}
}
