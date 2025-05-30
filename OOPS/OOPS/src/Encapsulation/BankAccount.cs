namespace OOPS.src.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal amount)
        {
            Deposit(amount);
        }

        public decimal GetBalance()
        {
            return balance;
        }


        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit must be more than zero.");
            }

            this.balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw must be more than zero.");
            }

            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient fund.");
            }

            this.balance -= amount;
        }


    }
    
}