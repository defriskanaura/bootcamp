//Single Delegate
public delegate void MyDelegate();
class Program {
	static void Main() {
		MyDelegate mydel = Displayer;
		mydel.Invoke();
		mydel();
	}
	static void Displayer() {
		"Displayer".Dump();
	}
	static void Yusuf()
	{
		"Yusuf".Dump();
	}
}

public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}

