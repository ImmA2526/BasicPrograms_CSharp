//Day 1: Print Hello Messege With User Name
using System;
using System.Collections.Generic;
using System.Text;
namespace BasicProgram
{
    class Hello
    {
		public static void HelloWorld()
		{
			Console.WriteLine("Enter Name: ");
			string Name = Console.ReadLine();
			Console.WriteLine("Welcome To DotNet Programing: " + Name);
		}
	}
}
