using FooBar;
class Program 
{
	static void Main() 
	{
		FoobarController<int, string> origin = new();
		origin.Add(1, "Hello");
		origin.Add(1, "Aya");
		// Origin asli = new(1);
		// Substitute pengganti = new("Hello");
	}
}