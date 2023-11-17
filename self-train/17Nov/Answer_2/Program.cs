class Program 
{
	static void Main() 
	{
		FooBar foobar = new FooBar(15);
		foobar.Replace();
	}
}
class FooBar 
{
	int n;
	int[] array;
	public FooBar(int nX) 
	{
		nX = n;
	}
	public void Replace() 
	{
		for (int i = 1; i <= n; i++)
		{
			array[i] = i;
		}
		foreach (int items in array)
		{
			if (items % 3 == 0 || items % 5 == 0)
			{
				Console.Write("Foo ");
			}
			else 
			{
				Console.Write($"{items} ");
			}
		}
	}
}