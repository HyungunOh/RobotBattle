using System;

public class Robot
{
	public int hp;
	protected string _name;
	protected int _num;
	
	public string name
	{
		get { return _name; }
	}
	
	public int num
	{
		get { return _num; }
	}
	
	public bool isDead
	{
		get { return hp <= 0; }
	}
	
	public Robot(string newName)
	{
		Random r = new Random();
		hp = r.Next(8,11);
		_name = "Robot";
		_num = r.Next(1,11);
	}
};
