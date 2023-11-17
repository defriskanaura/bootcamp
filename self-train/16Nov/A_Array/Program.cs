//cara declare array 1
string[] fraudulentOrderIDse = new string[3];

fraudulentOrderIDse[0] = "A123";
fraudulentOrderIDse[1] = "B456";
fraudulentOrderIDse[2] = "C789";

//cara declare array 2
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//variable array can be changed/reassigned
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//usage of foreach array
int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int pembeda = 200;
foreach (int items in inventory)
{
	if (items % 100 == 0 || items % 50 == 0)
	{
		Console.Write("Foo ");
	}
	else 
	{
		Console.Write($"{items} ");
	}
}
//using string startswith
string[] fraudulentOrderID1 = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string id in fraudulentOrderID1)
{
	if (id.StartsWith("B"))
	{
		Console.WriteLine(id);
	}
}