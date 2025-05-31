namespace SOLID.DIP.PROBLEM;

public class Car
{
    private Engine _engine;
    
    public Car()
    {
        _engine = new Engine();
    }
    
    public void Start()
    {
        _engine.Start();
        Console.WriteLine("Car started.");
    }
}

/*
Direct Dependency: 
The Car class is directly creating and depending on the concrete Engine class. 
This creates a tight coupling between Car and Engine.

No Abstraction: 
There's no interface or abstraction layer between Car and Engine. 
The high-level module (Car) is directly dependent on the low-level module (Engine).

Hard-coded Implementation: 
The Engine is instantiated directly in the Car constructor, which means:
You can't easily swap different types of engines
You can't test the Car class with a mock engine

Any changes to the Engine class might require changes to the Car class
*/