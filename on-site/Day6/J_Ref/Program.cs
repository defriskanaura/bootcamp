//Value Type
//Ref
//Variable must be assigned before passed
class Program
{
	static void Main()
	{
		int a = 3;
		AddTwo(ref a);
		Console.WriteLine(a); // 5
	}
	static void AddTwo(ref int x) //ref = rujukan
	{
		x = x + 2;
	}
}