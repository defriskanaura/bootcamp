//Method Hiding
class Program
{
	static void Main()
	{
		Animal animal = new Animal();
		animal.MakeSound();
		
		Cat cat = new Cat();
		cat.MakeSound();
		
		Bird bird = new Bird();
		
		animal = bird;
		animal.MakeSound();
	}
}
class Animal
{
	public void MakeSound()
	{
		"Animal MakeSound".Dump();
	}
}
class Cat 
{
	public void MakeSound()
	{
		"Meow...".Dump();
	}
}
class Dog : Animal
{
	public new void MakeSound()
	{
		"Woof!...".Dump();
	}
}
class Bird : Animal
{
	public new void MakeSound()
	{
		"Chip...".Dump();
	}
}
class Ant : Animal { }
public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}





