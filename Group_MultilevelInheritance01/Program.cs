using System;

public class Person
{
    public void Speak()
    {
        Console.WriteLine("Person speaks");
    }
}

public class Employee : Person
{
    public void Work()
    {
        Console.WriteLine("The Employee is working...");
    }
}

public class Manager : Employee
{
    public void Manage()
    {
        Console.WriteLine("The manager manages the team for easy coordination");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Manager CrdbManager = new Manager();
        CrdbManager.Speak();
        CrdbManager.Work();
        CrdbManager.Manage(); 
    }
}
        