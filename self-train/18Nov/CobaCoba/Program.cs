using System;

namespace Tutlane
{
    class User
    {
        protected string Name;
        protected string Location;
        protected int Age;
        protected void GetUserDetails()
        {
           Console.WriteLine("Name: {0}", Name);
           Console.WriteLine("Location: {0}", Location);
           Console.WriteLine("Age: {0}", Age);
        }
    }
    class Program: User
    {
        static void Main(string[] args)
        {
           User u = new User();
           Program p = new Program();
           // Compiler Error
           // protected members can only be accessible with derived classes
           //u.Name = "Suresh Dasari";
           p.Name = "Suresh Dasari";
           p.Location = "Hyderabad";
           p.Age = 32;
           p.GetUserDetails();
           Console.WriteLine("\nPress Enter Key to Exit..");
           Console.ReadLine();
        }
    }
}