using System;
namespace BasicProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			int ch;
			while (true)
			{
				Console.Write("\n1.Hello World \n 2.Power of Number \n 3.Leap Year \n 4.Addition \n 5.GuessNumber" +
				"\n6.Tic \n Enter Your Choice :   ");
				ch = Convert.ToInt32(Console.ReadLine());
				switch (ch)
				{
					case 1:
						Hello.HelloWorld();
					break;
					case 2:
						PowerofNumber.Power();
					break;
					case 3:
						LeapYear.LepYear();
					break;
					case 4:
						Addition.Adition();
					break;
					case 5:
						GuessNumber.GuesNumber();
					break;
					case 6:
						TicDry.Tic();
					break;
					case 7:
						MergeSort.Merge();
					default:
						Console.WriteLine("\n Invalid Choice....");
					break;
				}
			}
		}
	}//class
}//namespace
