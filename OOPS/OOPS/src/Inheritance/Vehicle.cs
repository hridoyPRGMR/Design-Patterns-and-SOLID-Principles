namespace OOPS.src.Inheritance
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

        public void Start()
        {
            Console.WriteLine($"{Year} {Make} {Model} is starting.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Year} {Make} {Model} is stopping.");
        }

            
    }
}