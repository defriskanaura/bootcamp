namespace FooBar;
using System.Text;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Reflection.Metadata;

public class FoobarController<TOrigin, TSubstitute>
{
	private Dictionary<string, string> _wordDictionary;
	private Dictionary<string, string> _defaultDictionary;
	private string _key;
	private string _value;
	//create instance without default list
	public FoobarController() 
	{
		_wordDictionary = new();
		_defaultDictionary = new Dictionary<string, string>(){
							{"0", "0"}, {"1", "1"}, {"2", "2"}, {"3", "3"},
							{"4", "4"}, {"5", "5"}, {"6", "6"},
							{"7", "7"}, {"8", "8"}, {"9", "9"},
							{"10", "10"}, {"11", "11"}, {"12", "12"},
							{"13", "13"}, {"14", "14"}, {"15", "15"}};
	}
	//create instance with default list
	
	//override tostring, ubah input originKey ke string key
	public void ToString(TOrigin originKey, out string _key)
	{
		_key = originKey.ToString();
	}
	//override tostring, ubah input substituteValue ke value
	public void ToString(TSubstitute substituteValue, out string _value)
	{
		_value = substituteValue.ToString();
	}
	//override tostring, ubah input originKey dan substituteValue ke string key dan value
	public void ToString(TOrigin originKey, TSubstitute substituteValue, out string _key, out string _value)
	{
		_key = originKey.ToString();
		_value = substituteValue.ToString();
	}
	//method tambahin key value ke list
	public bool Add(TOrigin originKey, TSubstitute subsituteValue)
	{
		//ubah input parameter menjadi string
		ToString(originKey,subsituteValue,out _key,out _value);
		//cek apakah key sudah ditambahkan
		if(_wordDictionary.ContainsKey(_key)){ 
			return false;
		}
		//menambahkan key dan value ke list
		_wordDictionary.Add(_key,_value);
		return true;
	}
	//mengganti value
	public bool ChangeValue (TOrigin originKey, TSubstitute subsituteValue)
	{
		ToString(originKey, subsituteValue, out _key, out _value);
		if (!_wordDictionary.ContainsKey(_key)) 
		{
			return false;
		}
		_wordDictionary[_key] = _value;
		return true;
	}
	
	public bool FindKey (TOrigin originKey)
	{
		ToString(originKey, out _key);
		if (!_wordDictionary.ContainsKey(_key)) 
		{
			return false;
		}
		return true;
	}
	//mencari key value pada list
	public bool FindKeyValue(TOrigin originKey, TSubstitute subsituteValue)
	{
		//ubah input parameter menjadi string
		ToString(originKey, subsituteValue, out _key, out _value);
		//cek apakah key sudah ditambahkan
		if (!_wordDictionary.ContainsKey(_key))
		{
			return false;
		}
		//cek apakah input originKey dan substituteValue yang dimasukkan benar-benar menjadi pair key value di list
		if (_wordDictionary[_key] != _value) 
		{
			return false;
		}
		return true;
	}
	//method hapus key value dari list
	public bool Remove(TOrigin originKey, TSubstitute subsituteValue)
	{
		//ubah input parameter menjadi string
		ToString(originKey, subsituteValue, out _key, out _value);
		//cek apakah key sudah ditambahkan
		if (!_wordDictionary.ContainsKey(_key))
		{
			return false;
		}
		//cek apakah input originKey dan substituteValue yang dimasukkan benar-benar menjadi pair key value di list
		if (_wordDictionary[_key] != _value) 
		{
			return false;
		}
		//hapus pair key value dari list
		else if (_wordDictionary[_key] == _value) 
		{
			_wordDictionary.Remove(_key);
		}
		return true;
	}
	//menghapus semua isi list
	public bool RemoveAll()
	{
		if (_wordDictionary == null) 
		{
			return false;
		}
		_wordDictionary.Clear();
		return true;
	}
	//method cetak isi list key value sebagai stringbuilder
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
	
	//method cetak isi list key value sebagai stringbuilder tapi dari belakang
	public StringBuilder PrintFromEnd()
	{
		StringBuilder WordShow = new();
		for (int i = _wordDictionary.Count - 1; i >= 0; i--)
		{
			if (_wordDictionary.ElementAt(i).Value != _wordDictionary.ElementAt(i).Key)
			{
				WordShow.Append(_wordDictionary.ElementAt(i).Value);
			}
			else 
			{
				WordShow.Append(_wordDictionary.ElementAt(i).Key);
			}
			WordShow.Append(" ");
		}
		return WordShow;
	}
	//method menambahkan list sekarang sebagai default list
	public bool SetCurrentasDefault()
	{
		if (_wordDictionary == null) 
		{
			return false;
		}
		_defaultDictionary = _wordDictionary;
		return true;
	}
	//method menambahkan default list sebagai list yang sekarang
	public void SetDefaultasCurrent()
	{
		_wordDictionary = _defaultDictionary;
	}
	//method untuk reset default menjadi nilai semula
	public void ResetDefault()
	{
		_defaultDictionary = new Dictionary<string, string>(){
							{"0", "0"}, {"1", "1"}, {"2", "2"}, {"3", "3"},
							{"4", "4"}, {"5", "5"}, {"6", "6"},
							{"7", "7"}, {"8", "8"}, {"9", "9"},
							{"10", "10"}, {"11", "11"}, {"12", "12"},
							{"13", "13"}, {"14", "14"}, {"15", "15"}};
	}
	//method mencetak default list sebagai stringbuilder
	public StringBuilder PrintDefault()
	{
		StringBuilder WordShow = new();
		foreach (var item in _defaultDictionary)
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

		// //cek apakah input x dan y yang dimasukkan benar-benar menjadi pair key value di list
		// bool isKeyValueMatch = false;
		// for (int i = 0; i < _wordDictionary.Count; i++)
		// {
		// 	if (_wordDictionary.ElementAt(i).Key == _key
		// 		&& _wordDictionary.ElementAt(i).Value == _value) 
		// 	{
		// 		isKeyValueMatch = true;
		// 		break;
		// 	}
		// 	isKeyValueMatch = false;
		// }
		// //hentikan method jika bukan pair key value di list
		// if (isKeyValueMatch == false)
		// {
		// 	return false;
		// }
// public FoobarController(bool isUsingDefault) 
// 	{
// 		_isUsingDefault = isUsingDefault;
// 		_defaultDictionary = new Dictionary<string, string>(){
// 							{"1", "1"}, {"2", "2"}, {"3", "3"},
// 							{"4", "4"}, {"5", "5"}, {"6", "6"},
// 							{"7", "7"}, {"8", "8"}, {"9", "9"},
// 							{"10", "10"}, {"11", "11"}, {"12", "12"},
// 							{"13", "13"}, {"14", "14"}, {"15", "15"}};
// 		_wordDictionary = new();
// 		if (_isUsingDefault == true) 
// 		{
// 			_wordDictionary = _defaultDictionary;
// 		};
// 	}
	// static void SomeMethod()
	// {
	// 	Console.WriteLine("SomeMethod was called!");
	// }

	// static void AnotherMethod()
	// {
	// 	Console.WriteLine("AnotherMethod was called!");
	// }
	
	// public void Test()
	// {
	//     (_isUsingDefault ? (Action)SomeMethod : AnotherMethod)();
	// }
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

