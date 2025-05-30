namespace OOPS.src.Polymorphism
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public virtual void Start()
        {
            Console.WriteLine($"{Year} {Make} {Model} is starting.");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"{Year} {Make} {Model} is stopping.");
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }
    }
}