//Multicast Delegate
public delegate void MyDelegate();
class Program
{
	static void Main()
	{
		MyDelegate mydel;
		Information info = new();
		
		mydel = info.Displayer;
		mydel += info.Yusuf;
		
		mydel.Invoke();
	}
}
class Information
{
	public void Displayer()
	{
		"Displayer".Dump();
	}
	public void Yusuf()
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