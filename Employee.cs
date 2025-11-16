using System;

// Employee class inherits the IQuitable interface.
public class Employee : IQuitable
{
    // Properties for employee name.
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implementation of the Quit() method required by the interface.
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}
