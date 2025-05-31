namespace SOLID.ISP.SOLUTION;

public class Circle : IShape2D
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}