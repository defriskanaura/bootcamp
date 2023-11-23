using System.Collections.Generic;
namespace CreateGame;

public class GameController
{
	private Player[] _players = new Player[4];
	public GameController(params Player[] players)
	{
		if (players.Length > 4) {throw new ArgumentOutOfRangeException;}
		
	}
	
}
