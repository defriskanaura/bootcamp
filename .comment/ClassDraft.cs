public UnoGame
{
	private GameStatus _gameStatus;
	private IPlayer _playerNow;
	private Dictionary<IPlayer, HashSet<ICard>> _cardsOnPlayer;
	private List<ICard> _possiblecards;
	private ICard _playedcard;
	private IDeck _cardsOnDeck;
	private ICard _cardOnTable;
	private Direction direction;
	
	public UnoGame(int maxPlayer, Player player) 
	{
		/*
			ketika instance UnoGame dibuat, maka instance _cardsOnDeck otomatis dibuat
			dan telah di shuffle
		*/
	}
	//nunggu player lain masuk gameroom
	public delegate Dictionary<IPlayer, HashSet<ICard>> ListenerPlayer(Player player); 
	
	public Dictionary<IPlayer, HashSet<ICard>> AddPlayer (Player player) 
	{
		/*
			return _cardOnTable, hapus satu kartu (_cardOnTable) dari deck (_cardsOnDeck)
		*/
		return _cardsOnPlayer;
	}
	StartGame return true false
	GetFirstCard return _cardOnTable
	public ICard StartGame() {
		/*
			method berisi hapus satu kartu (_cardOnTable) dari deck (_cardsOnDeck)
			method meemberi info tentang kartu apa yang harus ada di table, diambil random
			dari deck (_cardsOnDeck)
		*/
		return _cardOnTable;
	}
	public IPlayer SwitchPlayer() 
	{
		/*
			return player yang dapat giliran sekarang (_playerNow)
		*/
		return _playerNow;
	}
	private bool IsTherePossibleCard (Dictionary<IPlayer, HashSet<ICard>>[IPlayer] _cardsOnPlayer[_playerNow]], _cardOnTable) 
	{
		//
		if (IsCardMatch(params ICard[] cards)==false)
		{
			return false;
		}
		return true;
	}
	public Dictionary<IPlayer, HashSet<ICard>> CheckPossibleCard (_cardsOnPlayer[_playerNow]], _cardOnTable) 
	{
		if (IsTherePossibleCard(_cardsOnPlayer[_playerNow]], _cardOnTable) == false) 
		{
			return new Dictionary<IPlayer _playernow, HashSet<ICard>>();
		}
		/*
			cek kartu apa aja yang bisa dimainin player ketika ada kartu di meja
			panggil metode IsCardMatch();
		*/
		return _possiblecards;
	}
	satu pemain list card
	_playerNow, _cardOnTable
	public ICard PlayCard(_possiblecards) 
	{
		/*
			remove _possiblecards dari _cardsOnPlayer
		*/
		return _cardOnTable;
	}
	
	
}

/*
Enums {
	GameStatus : StandBy, GameRunning, SkippedAPlayer, 
	Direction : Clockwise, CounterClockwise
}
*/

public enum Direction
{
	Clockwise,
	CounterClockwise,
}
public enum GameStatus
{
	StandBy,
	GameRunning,
	SkippedAPlayer,
}

public interface IPlayer {
	public int Id {get;}
	public string Name {get;}
}

public class Player {
	public int Id {get;}
	public string Name {get;}
	
	public Player(int id, string name)
	{
		/*
			membuat instance player
		*/
	}
}

public interface ICard {
	public int id {get;}
	public Color color {get;}
	public CardType cardtype {get;}
	public bool isSpecialAbility {get; set;}
   public virtual bool SpecialAbility(UnoGame game) 
   {
   	 	//special ability card
		return true;
   }
	public virtual bool IsCardMatch(params ICard[] cards) 
	{
		//mengecek apakah kartu satu dengan kartu lainnya match
		return true;
	}
}

public interface IDeck {
	public HashSet<ICard> CardsOnDeck {get; set;}
}

public class Deck 
{
	public Deck (HashSet<ICard>)
	{
		
	}
	public bool RemoveCard(ICard){}
	public bool AddCard(ICard){}
}