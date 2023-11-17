/*
class Program {
	static void Main(){
		string? userInput;
		do{
			userInput = Console.ReadLine();
		} while (userInput == null || userInput.Length == 0 );
		var myArray = new string[userInput!.Length];
		Console.WriteLine(myArray.Length);
	}
}
*/
class Program 
{
	static void Main() 
	{
		WordPlay foobar = new WordPlay(15, "foo");
		foobar.Replace();
	}
}
class WordPlay 
{
	public readonly int n;
	public readonly string word;
	
	
	//constructor
	public WordPlay(int n, string word) 
	{
		this.n = n;
		this.word = word;
	}
	//method
	public void Replace()
	{
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
