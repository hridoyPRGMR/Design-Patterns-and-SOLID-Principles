
using OOPS.src.Abstraction;
using OOPS.src.Encapsulation;
// using OOPS.src.Inheritance;
using OOPS.src.Polymorphism;


// Encapsulation
// BadBankAccount bankAccount = new BadBankAccount();
// bankAccount.balance = 100;

// Console.WriteLine(bankAccount.balance);


// BankAccount bankAccount = new BankAccount(120);
// bankAccount.Deposit(30);

// bankAccount.Withdraw(150);
// // bankAccount.Withdraw(10);//exception

// Console.WriteLine(bankAccount.GetBalance());

// Abstraction
// EmailService emailService = new EmailService();
// emailService.SendEmail();

//Inheritance
// var car = new Car("Toyota", "Allion", 2005, 4, 4);
// car.Start();
// car.Stop();

//Polymorphism
// Car car = new Car("Toyota", "Allion", 2005, 4, 4);
// car.Start();
// car.Stop();


List<Vehicle> vehicles = new List<Vehicle>
{
    new Bike("Yamaha", "FZ", 2015, true),
    new Car("Honda", "Civic", 2010, 4, 5)
};

foreach (var vehicle in vehicles)
{
    vehicle.Start();
    
    if(vehicle is Bike bike)
    {
        bike.RingBell();
    }
}






