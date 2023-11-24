using System.Numerics;

namespace FooBar;
public class Filler<T>
{
	public T Value {get; set;}
	// public string substituteValue {get; set;}
	public Filler(T x)
	{
		Value = x;
	}
}

// public class Substitute : IFiller<string>
// {
// 	public string Value {get; set;}
// 	// public string substituteValue {get; set;}
// 	public Substitute(string y)
// 	{
// 		Value = y;
// 	}
// }