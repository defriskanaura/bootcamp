using Animal;
class Program 
{
	static void Main() 
	{
		//Instantiate instance by its constructor
		Cat anggora = new Cat("miu",5,true); //bikin object
		
		//Same, but different order
		Cat shortbritish = new Cat(age:3, name:"yusuf", isMale:true);
		
		//Parameterless constructor, and fill the variable	
		Cat munchkin = new Cat()
		{
			name = "yusuf",
			age = 3,
			isMale = false
		};
		
		Cat persia = new Cat();
		
		string food = "whiskas";
		anggora.Eat(food);
		shortbritish.Eat(food);
		munchkin.Eat(food);
		persia.Eat(food);g
	}
}