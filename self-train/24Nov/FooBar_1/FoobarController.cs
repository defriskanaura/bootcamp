//namespace FooBar;
using System.Text;
using System.Diagnostics;

public class FoobarController<TOrigin, TSubstitute>
{
	private Dictionary<string, string> _wordDictionary;
	private Dictionary<string, string> _defaultDictionary;
	private string _key;
	private string _value;
	private bool _isUsingDefault;
	public FoobarController() 
	{
		_wordDictionary = new();
		_isUsingDefault = false;
	}
	public FoobarController(bool isUsingDefault) 
	{
		_isUsingDefault = isUsingDefault;
		_defaultDictionary = new Dictionary<string, string>(){
							{"1", "1"}, {"2", "2"}, {"3", "3"},
							{"4", "4"}, {"5", "5"}, {"6", "6"},
							{"7", "7"}, {"8", "8"}, {"9", "9"},
							{"10", "10"}, {"11", "11"}, {"12", "12"},
							{"13", "13"}, {"14", "14"}, {"15", "15"}};
		_wordDictionary = new();
		if (_isUsingDefault == true) 
		{
			_wordDictionary = _defaultDictionary;
		};
	}
	public void ToString(TOrigin x, TSubstitute y, out string _key, out string _value)
	{
		_key = x.ToString();
		_value = y.ToString();
	}
	public bool SeeDefault()
	{
		if (_isUsingDefault == false) 
		{
			return false;
		}
		foreach (var item in _defaultDictionary)
		{
			Console.WriteLine($"{item.Key} = {item.Value}");
		}
		return true;
	}
	public bool Add(TOrigin x, TSubstitute y)
	{
		ToString(x,y,out _key,out _value);
		if(_wordDictionary.ContainsKey(_key)){ 
			return false;
		}
		_wordDictionary.Add(_key,_value);
		return true;
	}
	public StringBuilder Print()
	{
		StringBuilder WordShow = new();
		foreach (var item in _wordDictionary)
		{
			if (item.Value != item.Key) 
			{
				WordShow.Append(item.Value);
			}
			else 
			{
				WordShow.Append(item.Key);
			}
			WordShow.Append(" ");
		}
		return WordShow;
	}
}
	
		// foreach (var item in _wordDictionary)
		// {
		// 	Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
		// }
	// public bool Remove(TOrigin x, TSubstitute y)
	// {
	// 	if(_wordDictionary.ContainsKey(x)){ 
	// 		return false;
	// 	}
	// 	_wordDictionary.Add(x, y);
		// foreach (var item in _wordDictionary)
		// {
		//     Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
		// }
		// return true;
	// }
	// public void Add(int x, string y)
	// {
	// 	// Origin<int> origin = new(x);
	// 	// IFiller<int> origin1 = new(x);
	// }

