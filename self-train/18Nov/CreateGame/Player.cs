namespace CreateGame;

public class Player
{
		public int Id { get;}
		public string Name { get; }
		public HashSet<ICard> PlayerCard { get; set; }
		public Chip PlayerChip {get; set;}
}
