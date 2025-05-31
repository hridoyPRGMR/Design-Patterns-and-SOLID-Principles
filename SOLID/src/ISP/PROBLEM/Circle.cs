namespace SOLID.ISP.PROBLEM;

public class Circle : IShape
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

    // This method is not applicable for Circle, so it throws an exception
    public double Volume()
    {
        throw new InvalidOperationException("Volume calculation is not applicable for Circle.");
    }
}