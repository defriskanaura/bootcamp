using System;
using System.Threading.Tasks;

class Program
{
	static async Task Main()
	{
		Task result = Task.Run(() => AddAsync(3, 4));
		await result;
		Console.WriteLine($"Result: {result}");
	}

	static async Task AddAsync(int a, int b)
	{
		// Simulate an asynchronous operation
		await Task.Delay(1000);

		//return a + b;
	}
}

// using System;
// using System.Data.Common;
// using System.Threading.Tasks;

// class Program
// {
// 	static async Task Main() 
// 	{
// 		// Task <-- ThreadPool 
// 		// 	- blocking //Task.Delay //Task.Run()
// 		// 	- non blocking // async - await
// 		Task<int> result = Task.Run(() => AddAsync(3,4));
// 		int myResult = await result;
// 		Console.WriteLine(myResult);
// 	}
// 	static async Task<int> AddAsync(int a, int b) {
// 		await Task.Delay(300);
// 		return a + b;
// 	}
// }

// using System;
// using System.Data.Common;
// using System.Threading.Tasks;

// class Program
// {
// 	static async Task Main() 
// 	{
// 		// Task <-- ThreadPool 
// 		// 	- blocking //Task.Delay //Task.Run()
// 		// 	- non blocking // async - await
// 		int test = await Task.Run(() => MyMethod());
// 		var myResult = await AddAsync(3,4);
// 		Console.WriteLine(myResult);
// 	}
// 	static async Task<int> AddAsync(int a, int b) {
// 		await Task.Delay(300);
// 		return a + b;
// 	}
// 	static int MyMethod() 
// 	{
// 		return 10;
// 	}
// }
