using System;

namespace kevinhomework_02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string playerName; //Id
			int PChoice = 0;
			int RoChoice = 0;
			
			/*
			Greeting greet = new Greeting();
			greet.bye();
			
			Hello hi = new Hello();
			hi.bye();
			hi.cheer();
			
			return;
			*/
			
			
			
			Random random = new Random();
			
			/// robot initializing here...
			Robot robot1 = new Robot ("Robot");
			
			
			// Robot Attack : Random Number
			RoChoice = random.Next(1,4);
			
			Console.WriteLine ("enter your ID");
			playerName = Console.ReadLine();
			
			Console.WriteLine ("Your ID is :" + "" + playerName);
			
			Console.WriteLine (playerName + " VS " + robot1.name + " " + robot1.num + "Ho");
			
			Console.WriteLine ("HP :" + robot1.hp);
			
			//RoChoice = robot1.Attack();
			//PoChoice = player.Attack();
			
			Character character = new Character();
			Console.WriteLine( character.attack() );
			Console.WriteLine( character.robothp() );
			Console.WriteLine( character.playerhp() );
			
			c_attack cattack = new c_attack();
			
			cattack.attack();
			
			while (true)
			{	
				// Player Attack : Input Number
				Console.WriteLine ("\nGawhi =1 , Bawhi =2 , Bo =3");
				PChoice = (Console.Read()-48);
				Console.WriteLine ("\n" + "Your choice : (" + PChoice + ") - (" + RoChoice + ") Robot choice");
				
				Console.WriteLine("Result : ");
				//Result.Battle(PChoice, RoChoice);
				
				if (Result.Battle(PChoice, RoChoice) == 10)
				{
					robot1.hp = robot1.hp-3;
				}
				
				Console.WriteLine("RemainHp :" + robot1.hp);
				
				//if (robot1.hp <= 0)
				if (robot1.isDead)
				{
					Console.WriteLine("----------------");
					Console.WriteLine("Congratulation!!");
					Console.WriteLine("----------------");
					return;
				}
			}
			
		}
	}
}




public class Result
{
	public static int Battle (int a, int b) 
	{

		//case
		int c;
		c = 0;
		
		if (a == 1) //gawhi
		{
			if (b == 1)
			{
				Console.WriteLine("Draw");
			}
			else if (b == 2)
			{
				Console.WriteLine("Loser");
			}
			else if (b == 3)
			{
				Console.WriteLine("Winner");
				c = 10;
			}
		}
		else if (a == 2) //bawhi
		{
			if (b == 1)
			{
				Console.WriteLine("Winner");
				c = 10;
			}
			else if (b == 2)
			{
				Console.WriteLine("Draw");
			}
			else if (b == 3)
			{
				Console.WriteLine("Loser");
			}
		}
		else if (a == 3) //bo
		{
			if (b == 1)
			{
				Console.WriteLine("Loser");
			}
			else if (b == 2)
			{
				Console.WriteLine("Winner");
				c = 10;
			}
			else if (b == 3)
			{
				Console.WriteLine("Draw");
			}
		}
		else
		{
			Console.WriteLine("Error");
		}

		
		return c;
	}
	
};

/*
public class Convers
{
	public string str (int a)
	{
		
		string b;
		
		if(a == 1)
		{
			b = "Gawhi";
		}
		else if(a == 2)
		{
			b = "Bawhi";
		}
		else if (a == 3)
		{
			b = "Bo";
		}
		
		return b;
	}
	
}
*/