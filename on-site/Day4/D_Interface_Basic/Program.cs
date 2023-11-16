//Interface
public interface IPermintaanOrtu {
	void Kuliah();
}
public interface IPermintaanIstri
{
	void IPhone15();
}
class Parent {
	public string name;
}

class Human : Parent, IPermintaanOrtu, IPermintaanIstri
{
	public void IPhone15()
	{
		"Besok ya..".Dump();
	}

	public void Kuliah()
	{
		"UGM".Dump();
	}
}
public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}