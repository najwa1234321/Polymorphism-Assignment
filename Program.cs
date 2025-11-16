using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object and set name values.
        Employee emp = new Employee()
        {
            FirstName = "Nasim",
            LastName = "Misrabi"
        };

        // Polymorphism: Interface variable referring to an Employee object.
        IQuitable quitter = emp;

        // Calling the Quit() method using the interface reference.
        quitter.Quit();

        Console.ReadLine(); // Pause so user can see output.
    }
}

