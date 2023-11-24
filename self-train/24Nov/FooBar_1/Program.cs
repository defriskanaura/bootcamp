using FooBar;
class Program 
{
	static void Main() 
	{
		// FoobarController<int, string> origin = new();
		// origin.Add(1, "Hello");
		// origin.Add(2, "2");
		// Console.WriteLine(origin.Print());
		FoobarController<int, string> foobar = new(true);
		foobar.SeeDefault();
		// Origin asli = new(1);
		// Substitute pengganti = new("Hello");
	}
}