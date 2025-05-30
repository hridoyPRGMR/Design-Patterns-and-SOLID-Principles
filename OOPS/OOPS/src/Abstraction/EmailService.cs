namespace OOPS.src.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Sending email...");
            Console.WriteLine("Email sent successfully!");
            Disconnect();
        }

        private void Connect()
        {
            Console.WriteLine("Connecting to email server...");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticating email service...");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting from email server...");
        }
    }
}