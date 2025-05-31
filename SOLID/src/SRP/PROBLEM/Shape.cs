
namespace SOLID.SRP.PROBLEM;

public class Shape
{
    public ShapeType type { get; set; }
    public Double Radius { get; set; }
    public Double Length { get; set; }
    public Double Width { get; set; }


    public double calculateArea()
    {
        return type switch
        {
            ShapeType.Circle => Math.PI * Radius * Radius,
            ShapeType.Square => Length * Length,
            ShapeType.Rectangle => Length * Width,
            ShapeType.Triangle => 0.5 * Length * Width,
            _ => throw new NotSupportedException("Shape type not supported")
        };
    }
}