using System.Numerics;

namespace FooBar;

public class Filler<T> : IFiller<T> where T : IComparable<string>
{
	public T originValue {get; set;}
	public T substituteValue {get; set;}
	public Filler(T x, T y)
	{
		originValue = x;
		substituteValue = y;
	}
}