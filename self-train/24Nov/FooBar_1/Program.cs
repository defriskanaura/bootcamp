using FooBar;
class Program 
{
	static void Main() 
	{
		FoobarController<int, string> origin = new();
		Console.WriteLine($"default list saat membuat instance = {origin.PrintDefault()}");
		
		//menambahkan key value pada list		
		origin.Add(16, "Hello");
		origin.Add(17, "Hi");
		Console.WriteLine($"list sekarang yang sudah ditambah = {origin.Print()}");
		
		//menjadikan list yang sekarang sebagai default list
		origin.SetCurrentasDefault();
		Console.WriteLine($"ubah list yang sekarang menjadi default = {origin.PrintDefault()}");
		
		//menghapus seluruh isi list yang sekarang
		origin.RemoveAll();
		Console.WriteLine($"isi list sekarang yang sudah dihapus = {origin.Print()}");
		
		//mereset default list
		origin.ResetDefault();
		Console.WriteLine($"reset default list ke semula = {origin.PrintDefault()}");
		
		//set default list sebagai list yang digunakan sekarang
		origin.SetDefaultasCurrent();
		Console.WriteLine($"list yang digunakan sekarang = {origin.Print()}");
		
		//mencari key dan mengubah valuenya
		origin.Add(18, "Nihao");
		if (origin.FindKey(18) == true) 
		{
			origin.ChangeValue(18, "Aloha");
		}
		
		//ubah langsung tanpa mencari
		for (int items = 0; items <= 15; items++) 
		{
			if (items % 3 == 0 && !(items % 5 == 0) && !(items==0))
			{
				origin.ChangeValue(items, "Foo");
			}
			else if (items % 5 == 0 && !(items % 3 == 0) && !(items==0))
			{
				origin.ChangeValue(items, "Bar");
			}
			else if (items % 3 == 0 && items % 5 == 0 && !(items==0))
			{
				origin.ChangeValue(items, "Foobar");
			}
		}
		Console.WriteLine($"list hasil mengubah value = {origin.Print()}");
		
		//menghapus key dan value
		if (origin.FindKeyValue(18, "Aloha") == true) 
		{
			origin.Remove(18, "Aloha");
		}
		Console.WriteLine($"list hasil menghapus key dan value = {origin.Print()}");
		Console.WriteLine($"list yang sekarang dicetak dari key paling akhir = {origin.PrintFromEnd()}");
	}
}
		
		
		
		
		// FoobarController<int, string> origin2 = new(false);
		// Console.WriteLine(origin2.PrintDefault());
		//FoobarController<int, string> foobar = new(true);
		//foobar.SeeDefault();
		// Origin asli = new(1);
		// Substitute pengganti = new("Hello");
		
		