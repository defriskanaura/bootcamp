
// using System;
// using System.Diagnostics;
// using System.Text;

// class Program {
// 	static void Main() {
		
// 		StringBuilder sb = new StringBuilder();
// 		Stopwatch stopwatch = new Stopwatch();
// 		stopwatch.Start();
// 		for (int i = 0; i < 100000; i++) {
// 			sb.Append("a");
// 			sb.Append("b");
// 			sb.Replace('a', 'c');
// 		}
// 		stopwatch.Stop();
// 		Console.WriteLine(stopwatch.ElapsedMilliseconds);
// 	}
// }
using System;

class Program
{
    static void Main()
    {
        // Notasi iterasi menggunakan loop for
        for (int k = 8; k >= 1; k--)
        {
            // Lakukan sesuatu dengan nilai k
            Console.WriteLine("Iterasi ke-" + k);
        }
    }
}

