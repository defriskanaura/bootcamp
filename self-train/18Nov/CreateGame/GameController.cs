using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace CreateGame;
using CreateGame;
public class GameController
{
	private Dictionary<IPlayer, HashSet<ICard>> _playerscard;
	private Dictionary<IPlayer, HashSet<IChip>> _playerschip;
	private int _maximumPlayer;
	
	public GameController(int maximumPlayer, params IPlayer[] players)
	{
		_playerscard = new();
		_playerschip = new();
		_maximumPlayer = maximumPlayer;
		foreach (var i in players)
		{
			_playerscard.Add(i, new HashSet<ICard>());
			_playerschip.Add(i, new HashSet<IChip>());
		}
		if (players.Length > maximumPlayer) 
		{
			throw new ArgumentOutOfRangeException($"Cannot create a game, maximum player is {maximumPlayer}");
		}
	}
	
}
