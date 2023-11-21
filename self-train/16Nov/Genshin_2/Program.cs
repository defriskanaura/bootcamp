//library consumer nyatu sama console
class Program 
{
	static void Main() 
	{
		GenshinCharacter CharacterA = new();
		CharacterA.SetName();
		CharacterA.SetGender();
		CharacterA.SetHeight();
		CharacterA.SetElement();
		CharacterA.SetWeapon();
		CharacterA.GetCharacterInfo();
	}
}

public class CharacterAct
{
	public void ElementalSkill(string characterName) 
	{
		Console.WriteLine ($"{characterName} is doing elemental skill and stacking energy");	
	}
	public void ElementalBurst(string characterName)
	{
		Console.WriteLine ($"{characterName} is doing elemental burst once");
	}
	public void Idle(string characterName) 
	{
		Console.WriteLine ($"{characterName} is doing idle");	
	}
	public void Walk(string characterName) 
	{
		Console.WriteLine ($"{characterName} is walking 100 meters");	
	}
	public void Run(string characterName) 
	{
		Console.WriteLine ($"{characterName} is running 100 meters");	
	}
}

public class GenshinCharacter : CharacterAct
{
	private string _name = "";
	private string _gender = "";
	private string _height = "";
	private string _element = "";
	private string _weapon = "";
	
	public string SetName() 
	{
		Console.WriteLine("Write the name of your Genshin Character : ");
		while (_name == "")
		{
			_name = Console.ReadLine();
		}
		return _name;
	}
	public string GetName() 
	{
		return _name;
	}
	
	public string SetGender() 
	{
		Console.WriteLine("Choose your character's gender : ");
		Console.WriteLine("[Male]    [Female]");
		string[] listGender = {"Male", "Female"};
		do 
		{
			_gender = Console.ReadLine();
		}
		while (!listGender.Contains(_gender));
		return _gender;
	}
	public string GetGender() 
	{
		return _gender;
	}
		
	public string SetHeight() 
	{
		Console.WriteLine("Choose your character's height : ");
		Console.WriteLine("[Tall]    [Medium]    [Short]");
		string[] listHeight = {"Tall", "Medium", "Short"};
		do 
		{
			_height = Console.ReadLine();
		}
		while (!listHeight.Contains(_height));
		return _height;
	}
	public string GetHeight() 
	{
		return _height;
	}
			
	public string SetElement() 
	{
		Console.WriteLine("Choose your character's element : ");
		Console.WriteLine("[Anemo]    [Geo]    [Electro]    [Dendro]    [Hydro]    [Pyro]    [Cryo]");
		string[] listElement = {"Anemo", "Geo", "Electro", "Dendro", "Hydro", "Pyro", "Cryo"};
		do 
		{
			_element = Console.ReadLine();
		}
		while (!listElement.Contains(_element));
		return _element;
		// while (_element == "")
		// {
		// 	_element = Console.ReadLine();
		// }
		// return _element;
	}
	public string GetElement() 
	{
		return _element;
	}
	
	public string SetWeapon() 
	{
		Console.WriteLine("Choose your character's weapon : ");
		Console.WriteLine("[Catalyst]    [Polearm]    [Sword]    [Greatsword]    [Bow]");
		string[] listWeapon = {"Catalyst", "Polearm", "Sword", "Greatsword", "Bow"};
		do 
		{
			_weapon = Console.ReadLine();
		}
		while (!listWeapon.Contains(_weapon));
		//bool checkWeapon = Array.Exists(listWeapon, element => element == _weapon);
		return _weapon;
	}
	public string GetWeapon() 
	{
		return _weapon;
	}
	public void GetCharacterInfo() 
	{
		Console.WriteLine("\nGenerating character info...");
		Dictionary<string, string> listCharacterInfo = new Dictionary<string, string>() 
		{
			{"Name",GetName()},
			{"Gender",GetGender()},
			{"Height",GetHeight()},
			{"Element",GetElement()},
			{"Weapon",GetWeapon()}
		};
		foreach(KeyValuePair<string, string> items in listCharacterInfo)
		{
			Console.WriteLine("{0} : {1}", items.Key, items.Value);
		}
	}
}

}