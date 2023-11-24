namespace FooBar;

public interface IFiller<T>
{
	public T originValue {get; set;}
	public T substituteValue {get; set;}
}
