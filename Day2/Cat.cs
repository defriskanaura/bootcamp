namespace Animal;

public class Cat //Blueprint
{
	//Variable / Field
	public string colour;
	public int age;
	public bool isMale;
	public float weight;

	//Constructor
	public Cat(string colour) 
	{
		this.colour = colour;
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
