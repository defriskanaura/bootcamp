namespace Animal;

public class Cat //Blueprint
{
	//Variable / Field
	public string name;
	public int age;
	public bool isMale;
	public float weight;

	//Constructor
	public Cat(string name, int age, bool isMale) 
	{
		this.name = name;
		this.age = age;
		this.isMale = isMale;
	}
	public Cat() 
	{
		name = "kuceng";
		age = 0;
		isMale = false;
	}
		
	//Method / Function
	public void Eat(string makanan) 
	{
		Console.WriteLine($"Eat {makanan}");
	}
	public void Sleep() 
	{
		Console.WriteLine("Sleep");
	}
	public void Chaos() 
	{
		Console.WriteLine("Chaos");
	}
	public void Meow() 
	{
		Console.WriteLine("Meow");
	}
}
