//Reference Type
class Program
{
	static void Main()
	{
		MyInt myInt = new MyInt();
		myInt.value = 3;
		AddTwo(myInt);
		Console.WriteLine(myInt.value); // 5
		MyInt myIntNew = myInt; //myInt and myIntNew sharing the same address
		myIntNew.value = 2;
		Console.WriteLine(myInt.value);
		Console.WriteLine(myIntNew.value); 
	}
	static void AddTwo(MyInt a) // apakah a itu instance/objek yang dibuat dari class my int? instance bisa menjadi field?
	{
		a.value = a.value + 2;
	}
}
class MyInt
{
	public int value;
	public void Print(int x) 
	{
		Console.WriteLine(x);
	}
}