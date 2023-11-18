Random random = new Random();
string[] nomorAntrian = new string[1];
// Loop through each blank orderID
for (int i = 0; i < nomorAntrian.Length; i++)
{
	// Get a random value that equates to ASCII letters A through E
	int prefixValue = random.Next(65, 70);
	Console.WriteLine(prefixValue);
	// Convert the random value into a char, then a string
	string prefix = Convert.ToChar(prefixValue).ToString();
	Console.WriteLine(prefix);
	// Create a random number, pad with zeroes
	string suffix = random.Next(1, 1000).ToString("000");
	Console.WriteLine(suffix);
	// Combine the prefix and suffix together, then assign to current OrderID
	nomorAntrian[i] = prefix + suffix;
}
// Print out each orderID
foreach (var nomorAntrians in nomorAntrian)
{
	Console.WriteLine(nomorAntrians);
}