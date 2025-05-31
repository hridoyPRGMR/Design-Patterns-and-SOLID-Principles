namespace SOLID.ISP.SOLUTION;

public class Sphere : IShape3D
{   

    public double Radius { get; set; }

    public double Area()
    {
        return 4 * Math.PI * Radius * Radius;
    }

    public double Volume()
    {
        return (4.0 / 3.0) * Math.PI * Radius * Radius * Radius;
    }
}