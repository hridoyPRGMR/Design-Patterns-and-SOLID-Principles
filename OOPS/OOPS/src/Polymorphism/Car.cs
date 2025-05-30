namespace OOPS.src.Polymorphism
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }

        public Car(string make, string model, int year, int numberOfDoors, int numberOfSeats)
            : base(make, model, year)
        {
            NumberOfDoors = numberOfDoors;
            NumberOfSeats = numberOfSeats;
        }

        public override void Start()
        {
            Console.WriteLine($"{Year} {Make} {Model} with {NumberOfDoors} doors and {NumberOfSeats} seats is starting.");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Year} {Make} {Model} with {NumberOfDoors} doors and {NumberOfSeats} seats is stopping.");
        }
    }    
}