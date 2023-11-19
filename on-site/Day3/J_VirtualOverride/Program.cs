//Overriding (Virtual-Override)
class Program {
	static void Main() {
		Animal animal = new();
		animal.MakeSound();
		
		Cat cat = new();
		cat.MakeSound();
		
		Dog dog = new();
		dog.MakeSound();
		
		Ant ant = new();
		ant.MakeSound();
	}
}
class Animal {
	public virtual void MakeSound() {
		"Animal MakeSound".Dump();
	}
}
class Cat : Animal {
	public override void MakeSound() {
		"Meow...".Dump();
	}
}
class Dog : Animal
{
	public override void MakeSound()
	{
		"Woof!...".Dump();
	}
}
class Bird : Animal
{
	public override void MakeSound()
	{
		"Chip...".Dump();
	}
}
class Ant : Animal {}

//This is Extension Method
public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}





