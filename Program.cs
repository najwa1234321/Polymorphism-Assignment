using System;

class Program
{
    static void Main(string[] args)
    {
        // Create employee object
        Employee employee = new Employee()
        {
            FirstName = "Nasim",
            LastName = "Misrabi"
        };

        // Polymorphism: interface reference pointing to Employee object
        IQuitable quitter = employee;

        // Call Quit() method using the interface
        quitter.Quit();

        Console.ReadLine();
    }
}
