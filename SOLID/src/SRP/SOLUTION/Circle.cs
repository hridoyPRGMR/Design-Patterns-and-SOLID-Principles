
namespace SOLID.SRP.SOLUTION;

public class Circle : Shape
{   
    public double Radius { get; set; }
    
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}