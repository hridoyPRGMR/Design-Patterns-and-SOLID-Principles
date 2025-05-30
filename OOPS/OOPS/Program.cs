
using OOPS.src.Encapsulation;


// Encapsulation
// BadBankAccount bankAccount = new BadBankAccount();
// bankAccount.balance = 100;

// Console.WriteLine(bankAccount.balance);


BankAccount bankAccount = new BankAccount(120);
bankAccount.Deposit(30);

bankAccount.Withdraw(150);
// bankAccount.Withdraw(10);//exception

Console.WriteLine(bankAccount.GetBalance());





