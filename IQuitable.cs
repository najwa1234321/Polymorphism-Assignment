using System;

// This interface requires any class that inherits it to implement the Quit() method.
public interface IQuitable
{
    // Method that must be implemented by any class using this interface.
    void Quit();
}
