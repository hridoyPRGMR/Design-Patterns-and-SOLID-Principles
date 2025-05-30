using OOPS.src.Abstraction;
using OOPS.src.Composition;
using OOPS.src.Coupling;
using OOPS.src.Encapsulation;
// using OOPS.src.Inheritance;
// using OOPS.src.Polymorphism;


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


// List<Vehicle> vehicles = new List<Vehicle>
// {
//     new Bike("Yamaha", "FZ", 2015, true),
//     new Car("Honda", "Civic", 2010, 4, 5)
// };

// foreach (var vehicle in vehicles)
// {
//     vehicle.Start();

//     if(vehicle is Bike bike)
//     {
//         bike.RingBell();
//     }
// }


// Coupling
// var order1 = new Order(new EmailSender());
// order1.PlaceOrder();

// var order2 = new Order(new SmsSender());
// order2.PlaceOrder();



//Composition

// Composition is a way to build complex objects by combining simpler objects.
// Instead of inheriting behavior, you add objects as fields or properties.
// This means one class "has a" reference to another class, allowing you to reuse code easily.
// For example, a Car "has a" Engine and "has a" Wheel, instead of inheriting from them.

// When to use composition:
// - When you want to reuse functionality without creating rigid hierarchies.
// - When you need flexibility to change or extend behavior at runtime.
// - When you want to avoid the pitfalls of deep inheritance chains.
// - When you need to follow the "HAS-A" relationship rather than "IS-A".

// When not to use composition:
// - When the relationship between classes is clearly an "IS-A" relationship.
// - When inheritance provides a simpler and more natural solution.
// - When the added complexity of managing composed objects outweighs the benefits.
Car car = new Car();
car.Drive();






