using System;

// Employee class implements the IQuitable interface
public class Employee : IQuitable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implementation of Quit() method
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}
