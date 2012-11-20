using System;

public class Character
{
	protected string name;
	
	protected int curHP;
	protected int maxHP;
	
	
	public Character()
	{
		InitHP();
	}
	
	public Character(string newName)
	{
		name = newName;
		InitHP();
	}
	
	public void PrintInfo()
	{
		Console.WriteLine("{0}: {1}/{2}", name, curHP, php);
	}
	
	public virtual void InitHP()
	{
		//php = 10;
		Random r = new Random();
		maxHP = r.Next(8,11);
		curHP = maxHP;
	}
		
	public virtual int attack()
	{
		int a;
			
		Random random = new Random();
		a = random.Next(1,4);
		
		return a; 
	}
		
}


class Player : Character {

	
	public override void InitHP ()
	{
		maxHP = 10;
		curHP = maxHP;
	} 
	
	public override int attack() {
		int a;
		a = Console.Read();
		return a;
	}
}

class Robot : Character
{
	
}
