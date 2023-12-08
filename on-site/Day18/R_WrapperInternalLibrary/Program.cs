using System;
using System.Diagnostics;
using System.Threading;

public static class Program
{
	public static void Main()
	{
		Console.WriteLine("Starting program.");

		
		try 
		{
			Thread thread1 = new Thread(WrapperInternalLibrary);
			thread1.Start();
			thread1.Join();
		}
		catch(Exception e) 
		{
			
		}
		finally 
		{
			Console.WriteLine("End of program");
		}
	}
	public static void WrapperInternalLibrary() 
	{
		try
		{
			InternalLibrary();
		}
		catch(Exception e) 
		{
			
		}
	}
	public static void InternalLibrary()
	{
		Thread.Sleep(50);
		ExceptionMaker();
	}
	public static void ExceptionMaker() 
	{
		throw new Exception("ini exception");
	}
}