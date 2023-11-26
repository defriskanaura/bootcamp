using System;
using System.Linq;

using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		var cities = new Dictionary<string, string>(){
			{"UK", "London, Manchester, Birmingham"},
			{"USA", "Chicago, New York, Washington"},
			{"India", "Mumbai, New Delhi, Pune"}
		};

		Console.WriteLine("Total Elements: {0}", cities.Count);
		
		cities.Remove("UK"); // removes UK 
		//cities.Remove("France"); //throws run-time exception: KeyNotFoundException
		cities.Add("yes");
		for (int i = 0; i < cities.Count; i++)
{
    Console.WriteLine("Key: {0}, Value: {1}", 
                                            cities.ElementAt(i).Key, 
                                            cities.ElementAt(i).Value);
}

		cities.Clear(); //deletes all elements
		
		Console.WriteLine("Total Elements after Clear(): {0}", cities.Count);

	}
}
// using System;

// class Program
// {
//     static void SomeMethod()
//     {
//         Console.WriteLine("SomeMethod was called!");
//     }

//     static void AnotherMethod()
//     {
//         Console.WriteLine("AnotherMethod was called!");
//     }

//     static void Main()
//     {
//         bool myBool = true;

//         // Using ternary conditional operator to conditionally call a method
//         (myBool ? (Action)SomeMethod : AnotherMethod)();

//         // Output will be "SomeMethod was called!"
//     }
// }

// using static System.Console;

// class Person
// {
// 	public string Name
// 	{
// 		get; set;
// 	}
// 	public Person(string name)
// 	{
// 		Name = name;
// 	}
// }

// class Employee : Person
// {
// 	public string JobTitle
// 	{
// 		get; set;
// 	}

// 	public Employee(string name, string jobTitle) : base(name)
// 	{
// 		JobTitle = jobTitle;
// 	}
// }

// interface IGroup<out T>
// {
// 	IEnumerable<T> GetAll();
	
// 	public void Print()
// 	{
// 		Console.WriteLine("Test");
// 	}
// }

// class Group<T> : IGroup<T>
// {
// 	private readonly List<T> list = new();
// 	public Group(List<T> list)
// 	{
// 		this.list = list;
// 	}
// 	public Group()
// 	{
		
// 	}
// 	public IEnumerable<T> GetAll() => list;
	
// 	public void Print()
// 	{
// 		Console.WriteLine("Test");
// 	}
// }

// class Program
// {
// 	public static void Display(IGroup<Person> people)
// 	{
// 		foreach (var person in people.GetAll())
// 		{
// 			WriteLine(person.Name);
// 		}
// 	}

// 	public static void Main(string[] args)
// 	{
// 		var employees = new List<Employee>()
// 		{
// 			new Employee("John Doe","C# Developer"),
// 			new Employee("Jane Doe","UI/UX Developer")
// 		};

// 		IGroup<Employee> employeeGroup = new Group<Employee>(employees);
		
// 		Display(employeeGroup);
// 		employeeGroup.Print();
// 		Console.WriteLine(employees[0].JobTitle);
		
		
// 		Group<string> x = new Group<string>();
// 		x.Print();
// 	}
// }
// using System;

// namespace Tutlane
// {
//     class User
//     {
//         protected string Name;
//         protected string Location;
//         protected int Age;
//         protected void GetUserDetails()
//         {
//            Console.WriteLine("Name: {0}", Name);
//            Console.WriteLine("Location: {0}", Location);
//            Console.WriteLine("Age: {0}", Age);
//         }
//     }
//     class Program: User
//     {
//         static void Main(string[] args)
//         {
//            User u = new User();
//            Program p = new Program();
//            // Compiler Error
//            // protected members can only be accessible with derived classes
//            //u.Name = "Suresh Dasari";
//            p.Name = "Suresh Dasari";
//            p.Location = "Hyderabad";
//            p.Age = 32;
//            p.GetUserDetails();
//            Console.WriteLine("\nPress Enter Key to Exit..");
//            Console.ReadLine();
//         }
//     }
// }
//Object weakness
//No type check
// using System.Collections;
// class Program
// {
// 	static void Main()
// 	{
// 		//Fixed Size
// 		//Not safety
// 		int[] myArray = {1,2,3,4,5};
// 		foreach (var i in myArray)
// 		{
// 			Console.Write($"{i} ");
// 		}
// 		string a = "200";
// 		int aa = int.Parse(a);
// 		int ab = Convert.ToInt32(a);
// 		bool ac = int.TryParse(a, out int value);
// 		if (ac == true)
// 		{
// 			Console.WriteLine($"value = {value}");
// 		}
// 		Console.WriteLine ($"aa = {aa} ab = {ab}");
// 		int b = 200;
// 		double ba = b; //upcasting
// 		Console.WriteLine ($"ba = {ba}");
		
// 		double c = 200.89;
// 		int ca = (int) c; //downcasting
// 		Console.WriteLine ($"ca = {ca}");
		
// 		string d = "200.89";
// 		double da = Convert.ToDouble(d);
// 		double db = double.Parse(d);
// 		bool dc = double.TryParse(d, out double value1);
// 		decimal dd = (decimal) c;
// 		Console.WriteLine ($"da = {da} db = {db} dc = {dc} dd = {dd}");
		
// 		Type type = myArray[0].GetType();
// 		Console.WriteLine(type.Name);
// 		int v = (int)myArray[0];
// 		Console.WriteLine(v);
// 		string name = "Mahesh Chand";  
// 		Console.WriteLine("nama = {0}", name);
// 	}
// }
// object a = true;
// string result = a as string;

// using System;

// namespace DoFactory.GangOfFour.Abstract.RealWorld
// {
//     /// <summary>
//     /// MainApp startup class for Real-World
//     /// Abstract Factory Design Pattern.
//     /// </summary>

//     class MainApp
//     {
//         /// <summary>
//         /// Entry point into console application.
//         /// </summary>

//         public static void Main()
//         {
//             // Create and run the African animal world

//             ContinentFactory africa = new AfricaFactory();
//             AnimalWorld world = new AnimalWorld(africa);
//             world.RunFoodChain();

//             // Create and run the American animal world

//             ContinentFactory america = new AmericaFactory();
//             world = new AnimalWorld(america);
//             world.RunFoodChain();

//             // Wait for user input

//             Console.ReadKey();
//         }
//     }


//     /// <summary>
//     /// The 'AbstractFactory' abstract class
//     /// </summary>

//     abstract class ContinentFactory
//     {
//         public abstract Herbivore CreateHerbivore();
//         public abstract Carnivore CreateCarnivore();
//     }

//     /// <summary>
//     /// The 'ConcreteFactory1' class
//     /// </summary>

//     class AfricaFactory : ContinentFactory
//     {
//         public override Herbivore CreateHerbivore()
//         {
//             return new Wildebeest();
//         }
//         public override Carnivore CreateCarnivore()
//         {
//             return new Lion();
//         }
//     }

//     /// <summary>
//     /// The 'ConcreteFactory2' class
//     /// </summary>

//     class AmericaFactory : ContinentFactory
//     {
//         public override Herbivore CreateHerbivore()
//         {
//             return new Bison();
//         }
//         public override Carnivore CreateCarnivore()
//         {
//             return new Wolf();
//         }
//     }

//     /// <summary>
//     /// The 'AbstractProductA' abstract class
//     /// </summary>

//     abstract class Herbivore
//     {
//     }

//     /// <summary>
//     /// The 'AbstractProductB' abstract class
//     /// </summary>

//     abstract class Carnivore
//     {
//         public abstract void Eat(Herbivore h);
//     }

//     /// <summary>
//     /// The 'ProductA1' class
//     /// </summary>

//     class Wildebeest : Herbivore
//     {
//     }

//     /// <summary>
//     /// The 'ProductB1' class
//     /// </summary>

//     class Lion : Carnivore
//     {
//         public override void Eat(Herbivore h)
//         {
//             // Eat Wildebeest

//             Console.WriteLine(this.GetType().Name +
//               " eats " + h.GetType().Name);
//         }
//     }

//     /// <summary>
//     /// The 'ProductA2' class
//     /// </summary>

//     class Bison : Herbivore
//     {
//     }

//     /// <summary>
//     /// The 'ProductB2' class
//     /// </summary>

//     class Wolf : Carnivore
//     {
//         public override void Eat(Herbivore h)
//         {
//             // Eat Bison

//             Console.WriteLine(this.GetType().Name +
//               " eats " + h.GetType().Name);
//         }
//     }

//     /// <summary>
//     /// The 'Client' class 
//     /// </summary>

//     class AnimalWorld
//     {
//         private Herbivore _herbivore;
//         private Carnivore _carnivore;

//         // Constructor

//         public AnimalWorld(ContinentFactory factory)
//         {
//             _carnivore = factory.CreateCarnivore();
//             _herbivore = factory.CreateHerbivore();
//         }

//         public void RunFoodChain()
//         {
//             _carnivore.Eat(_herbivore);
//         }
//     }
// }

