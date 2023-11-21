//Enum
//List of Const
static void Main() {
	string month = MonthOfYear.January.ToString();
	int count = (int)MonthOfYear.January;
	month.Dump();
	count.Dump();
	
	int x = 4;
	MonthOfYear result = (MonthOfYear) x;
	result.Dump();
	
	int result2 = (int)MonthOfYear.January;
	result2.Dump();
}
public enum MonthOfYear
{
	January = 1,
	February = 2,
	Maret = 3,
	April = 4,
	Mei = 5,
	Juni = 6,
	Juli = 7,
	Agustus = 8,
	September = 9,
	October = 10,
	November = 11,
	Desember = 12
}
public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}