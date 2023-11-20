//Const
class Program
{
	static void Main()
	{
		MathLib math = new();
		 
		MathLib.phi.Dump();
	}
}

class MathLib {
	public const int phi = 314;
}

public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}