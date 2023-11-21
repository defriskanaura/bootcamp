//Value Type
//In = ReadOnly
//Variable must be assigned before passed
//But its ReadOnly

class Program
{
	static void Main()
	{
		int a = 3;
		AddTwo(a);
		Console.WriteLine(a); // ? 3 , 5
		
	}
	static void AddTwo(in int x)
	{
		//x = x + 3; <- Error, change value not possible
		x.Dump();
	}
}
public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}