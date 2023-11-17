
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
// class Program 
// {
// 	static void Main() 
// 	{
// 		WordPlay foobar = new WordPlay(15, "foo");
// 	}
// }
// class WordPlay 
// {
// 	public readonly int n = 6;
// 	public readonly string word;
	
// 	//constructor
// 	public WordPlay(int n, string word) 
// 	{
// 		this.n = n;
// 		this.word = word;
// 	}
// }
