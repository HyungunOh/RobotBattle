using System;

public class Greeting
{
	public virtual void bye()
	{
		Console.WriteLine("good bye");
	}
	
	public Greeting ()
	{
	}
}

class RobotFactory
{
	protected Robot [] robots = new Robot[10];
	
	public Robot this[int i]
	{
		get 
		{
			if (i < 0 && i >= robots.Length)
			{
				return null;
			}
			
			if (robots[i] == null)
			{
				robots[i] = new Robot(string.Format("Robot{0}", i.ToString()));
			}
			
			return robots[i]; 
		}
	}
}

class Hello : Greeting {
	
	public override void bye ()
	{
		//base.bye ();
		Console.WriteLine("hello");
	}
	
	public void cheer() 
	{
		Console.WriteLine("cheer");
		
		Robot [] factory = new Robot[10];
		RobotFactory factory2 = new RobotFactory();
		
		Robot target2 = factory2[10];
		if (target2 != null)
		{
			target2.hp = 100;
		}
		
		Robot target1 = factory[10];
		if (target1 != null)
		{
			target1.hp = 100;
		}
		
		
	}
}