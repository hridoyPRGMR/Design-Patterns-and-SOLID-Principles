//SRP
/*
A class should have only one reason to change, meaning it should only have one job or responsibility. 
This principle helps in reducing the complexity of the code and makes it easier to maintain.
*/

// using SOLID.SRP.SOLUTION;

// Shape shape = new Rectangle
// {
//     Width = 5,
//     Height = 10
// };

// double v = shape.CalculateArea();
// Console.WriteLine($"Area of the rectangle: {v}");

// List<Shape> shapes =
// [
//     new Rectangle { Width = 5, Height = 10 },
//     new Circle { Radius = 3 }
// ];

// foreach (var s in shapes)
// {
//     Console.WriteLine($"Area of the {s.GetType().Name}: {s.CalculateArea()}");
// }

//LSP - Liskov Substitution Principle
/*
*Objects in a program should be replaceable with instances of their subtypes without 
altering the correctness of the program.
*This means that subclasses should behave in such a way that they do not break the functionality
expected from the base class.
*/

// using SOLID.LSP.PROBLEM;

// // var rect = new Rectangle();
// var rect = new Square(); // Using Square which is a subclass of Rectangle
// rect.Height = 10;
// rect.Width = 5;
// Console.WriteLine("Expected area of rectangle: 10 * 5 = 50");
// Console.WriteLine($"Actual area of rectangle: {rect.Area}");

// using SOLID.LSP.SOLUTION;

// Shape rect = new Rectangle
// {
//     Width = 5,
//     Height = 10
// };
// Console.WriteLine("Expected area of rectangle: 5 * 10 = 50");
// Console.WriteLine($"Actual area of rectangle: {rect.Area}");

// Shape square = new Square
// {
//     SideLength = 5
// };
// Console.WriteLine("Expected area of square: 5 * 5 = 25");
// Console.WriteLine($"Actual area of square: {square.Area}");


// ISP - Interface Segregation Principle
/*
*Clients should not be forced to depend on interfaces they do not use.
*This principle encourages the creation of smaller, more specific interfaces rather than a large, general-purpose interface.
*/

// using SOLID.ISP.PROBLEM;

// var circle = new Circle()
// {
//     Radius = 5
// };
// Console.WriteLine($"Area of Circle: {circle.Area()}");
// Console.WriteLine($"Volume of Circle: {circle.Volume()}"); // This will throw an exception  

using SOLID.ISP.SOLUTION;

var circle = new Circle()
{
    Radius = 5
};
Console.WriteLine($"Area of Circle: {circle.Area()}");

var sphere = new Sphere()
{
    Radius = 4
};
Console.WriteLine($"Area of Square: {sphere.Area()}");
Console.WriteLine($"Volume of Sphere: {sphere.Volume()}");






