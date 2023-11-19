//Implementation of Overriding
class Program {
	static void Main() {
		ElectricEngine ee = new();
		HydroEngine he = new();
		
		Car car = new Car(ee);
		car.EngineRun();
		
		Car car1 = new Car(he);
		car1.EngineRun();
	}
}
class Car {
	public Engine engine;
	public void EngineRun() {
		engine.Start();
	}
	public Car(Engine engine) {
		this.engine = engine;
	}
}
class Engine {
	public virtual void Start() {
		"Engine Starting".Dump();
	}
}
class ElectricEngine : Engine {
	public new void Start() {
		"EE Starting".Dump();
	}
}
class HydroEngine : Engine {
	public override void Start() {
		"Hydro Engine Starting".Dump();
	}
}

public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}