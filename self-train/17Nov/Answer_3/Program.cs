class Program 
{
	static void Main() 
	{
		WordPlay foobar = new WordPlay();
		foobar.Play();
	}
}
class WordPlay 
{
	private string _stringAngka = GetAngka();
	//method
	private static string GetAngka()
	{
	 Console.WriteLine("Masukkan banyaknya angka: ");
	 return Console.ReadLine();
	}
	public void Play()
	{
		var n = int.Parse(_stringAngka);
		Console.WriteLine(n);
		int[] arrayWord = new int[n+1];
		for (int i = 0; i < n+1; i++)
		{
			arrayWord[i] = i;
		}
		
		foreach (int items in arrayWord)
		{
			if (items % 3 == 0 && !(items % 5 == 0) && !(items==0))
			{
				Console.Write("foo ");
			}
			else if (items % 5 == 0 && !(items % 3 == 0) && !(items==0))
			{
				Console.Write("bar ");
			}
			else if (items % 3 == 0 && items % 5 == 0 && !(items==0))
			{
				Console.Write("foobar ");
			}
			else 
			{
				Console.Write($"{items} ");
			}
		}
	}
}
