class Program {
	static void Main(){
		int[] inventory = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
		foreach (int items in inventory)
		{
			if (items==0)
			{
				Console.Write($"{items} ");
			}
			else if (items % 3 == 0 && !(items % 5 == 0))
			{
				Console.Write("foo ");
			}
			else if (items % 5 == 0 && !(items % 3 == 0))
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