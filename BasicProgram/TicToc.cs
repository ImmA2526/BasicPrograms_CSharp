using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
	class TicToc
	{
		static char[] PlayerSign = { 'X', 'O' };
		static char[] Board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
		static bool inputCorrect = true;
		static int Player = 2, input = 0,Turn = 0;
		public static void Tic()
		{
			Console.WriteLine("********** Welcome To Tic Tac To **********");
			do
			{
				if (Player == 2)
				{
					Player = 1;
					XorO(Player, input);
				}
				else if (Player == 1)
				{
					Player = 2;
					XorO(Player, input);
				}
				//Caling Method
				Board1();
				Turn++;
				VerticalWin();
				HorizontolWin();
				DiagWin();
				LineWin();
				if (Turn == 10)
				{
					Console.WriteLine("Draw Game");
					Console.Clear();
					ResetBoard();
				}
				do
				{
					Console.WriteLine("Ready Player: {0} its ur Turn", Player);
					try
					{
						Console.WriteLine("Enter Slot Number To Put Value:  ");
						input = Convert.ToInt32(Console.ReadLine());
					}
					catch
					{
						Console.WriteLine("Enter Valid Number...");
					}
					//Cheking Input
					if ((input == 1) && (Board[0] == '1') || (input == 2) && (Board[1] == '2')|| (input == 3) && (Board[2] == '3')
					|| (input == 4) && (Board[3] == '4') || (input == 5) && (Board[4] == '5') || (input == 6) && (Board[5] == '6')
					|| (input == 7) && (Board[6] == '7')|| (input == 8) && (Board[7] == '8')|| (input == 9) && (Board[8] == '9'))
					{ 
						inputCorrect = true;
					}
					else
					{
						Console.WriteLine("Slot Alredy Taken....");
						inputCorrect = false;
					}
				} while (!inputCorrect);
			} while (true);
		}
		//Genrating Board
		public static void Board1()
		{
			Console.WriteLine("  {0}  |  {1}  |  {2}", Board[0], Board[1], Board[2]);
			Console.WriteLine("--- --- --- ----");
			Console.WriteLine("  {0}  |  {1}  |  {2}", Board[3], Board[4], Board[5]);
			Console.WriteLine("--- --- --- ----");
			Console.WriteLine("  {0}  |  {1}  |  {2}", Board[6], Board[7], Board[8]);
			Console.WriteLine("--- --- --- ----");
		}
		//Reseting Board
		public static void ResetBoard()
		{
			char[] InitBoard = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
			Board = InitBoard;
			Board1();
			Turn = 0;
		}
		//Player Moving Code
		public static void XorO(int Player, int input)
		{
			char PlayerSign=' ';
			if (Player == 1) PlayerSign = 'X';
			else if (Player == 2) PlayerSign = 'O';
			switch (input)
			{
				case 1:	Board[0] = PlayerSign;	break;
				case 2:	Board[1] = PlayerSign;	break;
				case 3:	Board[2] = PlayerSign;	break;
				case 4:	Board[3] = PlayerSign;	break;
				case 5:	Board[4] = PlayerSign;	break;
				case 6:	Board[5] = PlayerSign;	break;
				case 7:	Board[6] = PlayerSign;	break;
				case 8:	Board[7] = PlayerSign;	break;
				case 9:	Board[8] = PlayerSign;	break;
			}
		}
		
		//Winning Code
		public static void VerticalWin()
		{
			foreach (char PlayerSig in PlayerSign)
			{
				if (((Board[0] == PlayerSig) && (Board[3] == PlayerSig) && (Board[6] == PlayerSig))
					|| ((Board[1] == PlayerSig) && (Board[4] == PlayerSig) && (Board[7] == PlayerSig))
					|| ((Board[2] == PlayerSig) && (Board[5] == PlayerSig) && (Board[8] == PlayerSig)))
				{
					Console.Clear();
					if (PlayerSig == 'X')
					{
						Console.WriteLine("Player 1 win");
						break;
					}
					else
					{
						Console.WriteLine("Player 2 win");
						break;
					}
				}
			}	
		}
		public static void HorizontolWin()
		{
			foreach (char PlayerSig in PlayerSign)
			{
				if (((Board[0] == PlayerSig) && (Board[3] == PlayerSig) && (Board[6] == PlayerSig))
				|| ((Board[1] == PlayerSig) && (Board[4] == PlayerSig) && (Board[7] == PlayerSig)))
				{
					Console.Clear();
					if (PlayerSig == 'X')
					{
						Console.WriteLine("Player 1 win");
						break;
					}
					else
					{
						Console.WriteLine("Player 2 win");
						break;
					}
				}
			}
		}
		public static void DiagWin()
		{
			foreach (char PlayerSig in PlayerSign)
			{
				if (((Board[0] == PlayerSig) && (Board[4] == PlayerSig) && (Board[8] == PlayerSig)
					|| (Board[2] == PlayerSig) && (Board[4] == PlayerSig) && (Board[6] == PlayerSig)))
				{
					Console.Clear();
					if (PlayerSig == 'X')
					{
						Console.WriteLine("Player 1 Win");
						break;
					}
					else
					{
						Console.WriteLine("Player 2 Win");
						break;
					}
				}
			}
		}
		public static void LineWin()
		{
			foreach (char PlayerSig in PlayerSign)
			{
				if(((Board[0]==PlayerSig)&&(Board[1]==PlayerSig)&&(Board[2]==PlayerSig)
					||(Board[3]==PlayerSig)&&(Board[4]==PlayerSig)&&(Board[5]==PlayerSig)
					||(Board[6]==PlayerSig)&&(Board[7]==PlayerSig)&&(Board[8]==PlayerSig)))
				{
						if (Player == 'X')
						{
							Console.WriteLine("Player 1 Win");
							break;
						}
						else
						{
							Console.WriteLine("Player 2 Win");
							break;
						}
				}
			}
		}
	}//class
}//namespace