//Multicast Delegate
public delegate void MyDelegate();
class Program
{
	static void Main()
	{
		MyDelegate mydel = Displayer;
		mydel += Yusuf;
		mydel.Invoke(); //Displayer Yusuf
		
		mydel -= Displayer;
		mydel(); //Yusuf
	}
	static void Displayer()
	{
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