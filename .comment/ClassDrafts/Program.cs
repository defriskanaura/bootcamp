public UnoGame
{
	private GameStatus _gameStatus;
	private IPlayer _playerNow;
	private Dictionary<IPlayer player, HashSet<ICard>> _cardsOnPlayer;
	private HashSet<ICard> _possiblecards;
	private ICard _playedcard;
	private CardsOnDeck _cardsOnDeck;
	private ICard _cardOnTable;
	
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
	}
	public ICard StartGame() {
		/*
			method berisi hapus satu kartu (_cardOnTable) dari deck (_cardsOnDeck)
			method meemberi info tentang kartu apa yang harus ada di table, diambil random
			dari deck (_cardsOnDeck)
		*/
		return _cardOnTable;
	}
	public IPlayer SwitchPlayer(Direction) 
	{
		/*
			return player yang dapat giliran sekarang (_playerNow)
		*/
		return _playerNow;
	}
	public _possiblecards CheckPossibleCard (_cardsOnPlayer[_playerNow]], _cardOnTable) 
	{
		/*
			cek kartu apa aja yang bisa dimainin player
		*/
	}
}

