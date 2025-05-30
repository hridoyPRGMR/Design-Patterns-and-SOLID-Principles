namespace OOPS.src.Composition
{
    public class Car
    {
        private readonly Engine _engine = new Engine();
        private readonly Chassis _chassis = new Chassis();
        private readonly Wheels _wheels = new Wheels();
        private readonly Seats _seats = new Seats();

        public void Drive()
        {
            _chassis.Support();
            _engine.Start();
            _wheels.Rotate();
            _seats.Sit();
            Console.WriteLine("Car is driving.");
        }

    }
}