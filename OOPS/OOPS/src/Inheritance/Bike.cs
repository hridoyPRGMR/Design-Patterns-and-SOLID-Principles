namespace OOPS.src.Inheritance
{
    public class Bike : Vehicle
    {
        public bool HasCarrier { get; set; }
        public int NumberOfWheels { get; set; } = 2; // Default value for bikes

        public Bike(string make, string model, int year, bool hasCarrier, int numberOfWheels = 2)
            : base(make, model, year)
        {
            HasCarrier = hasCarrier;
            NumberOfWheels = numberOfWheels;
        }

        public void RingBell()
        {
            Console.WriteLine($"{Year} {Make} {Model} is ringing the bell.");
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model} with {(HasCarrier ? "a carrier" : "no carrier")}";
        }
    }
}