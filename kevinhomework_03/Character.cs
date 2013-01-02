using System;

public class Character
{
	
	protected int php;
	
	public virtual int playerhp ()
	{
		int a = 10;
		
		return a;	
	}
		
	public int robothp ()
	{
		int hp;
		Random r = new Random();
		hp = r.Next(8,11);
		
		return hp;
	}
		
	public virtual int attack()
	{
		int a;
			
		Random random = new Random();
		a = random.Next(1,4);
		
		return a; 
	}
		
}


class c_attack : Character {
	
	public override int attack() {
		int a;
		a = Console.Read();
	
		return a;
	}
}
	
