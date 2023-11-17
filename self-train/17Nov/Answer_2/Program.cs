
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

