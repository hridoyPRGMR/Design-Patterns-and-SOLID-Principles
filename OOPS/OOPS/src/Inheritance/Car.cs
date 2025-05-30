namespace OOPS.src.Inheritance
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; } = 4;   // Default value for cars

        public Car(string make, string model, int year, int numberOfDoors, int numberOfWheels = 4)
            : base(make, model, year)
        {
            NumberOfDoors = numberOfDoors;
            NumberOfWheels = numberOfWheels;
        }

        public void Honk()
        {
            Console.WriteLine($"{Year} {Make} {Model} is honking.");
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model} with {NumberOfDoors} doors";
        }
    }
}