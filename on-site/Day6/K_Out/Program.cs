//Value Type
//Out
//Variable must be assigned before method end
class Program
{
	static void Main()
	{
		//out with static void method
		int a;
		AddTwo(out a);
		Console.WriteLine(a); // keluarannya 4
		
		int b = 2;
		
		//return with non-static non-void method
		Program program = new();
		Console.WriteLine(program.AddTwo(b)); //keluarannya 4
		
		//return with static non-void method
		int c = AddTwoX(b);
		Console.WriteLine(c); // keluarannya 4
		
		//out with non-static non-void method
		Program program2 = new();
		int d=2;
		program2.AddTwo2(out d);
		Console.WriteLine(d); //keluarannya 4
		Console.WriteLine(program2.AddTwo2(out d)); // keluarannya 100000
	}
	static void AddTwo(out int x) // what's the difference between out and return? which one is more efficient for method?
	{
		x = 2;
		x = x + 2;
	}
	
	int AddTwo(int x) 
	{
		x = x + 2;
		return x;
	}
	
	static int AddTwoX(int x) 
	{
		x = x + 2;
		return x;
	}
	int AddTwo2(out int x) 
	{
		x = 2;
		x = x + 2;
		int b = 100000;
		return b;
	}
}
/*
https://stackoverflow.com/a/68629467
Please avoid using out parameters.

Although, they can make sense in certain situations (for example when implementing the Try-Parse Pattern), they are very hard to grasp.

Chances to introduce bugs or side effects by yourself (unless you are very experienced with the concept) and by other developers (who either use your API or may inherit your code) is very high.

According to Microsoft's quality rule CA1021:
Although return values are commonplace and heavily used, the correct application of out and ref parameters requires intermediate design and coding skills. Library architects who design for a general audience should not expect users to master working with out or ref parameters.

Therefore, if there is not a very good reason, please just don't use out or ref.
*/