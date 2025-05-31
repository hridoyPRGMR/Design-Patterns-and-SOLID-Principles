namespace SOLID.DIP.SOLUTION;
public class Car
{
    private IEngine _engine;

    public Car(IEngine engine)
    {
        _engine = engine;
    }

    public void Start()
    {
        _engine.Start();
        Console.WriteLine("Car is ready to go!");
    }
}