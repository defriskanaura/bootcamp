using CreateGame;

class Program 
{
	static void Main()
	{
		Player player1 = new();
		Player player2 = new();
		Player player3 = new();
		Player player4 = new();
		Player player5 = new();
		GameController game = new GameController(player1, player2, player3, player4, player5);
	}
	
}