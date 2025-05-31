namespace SOLID.SRP
{
    public class EmailSender
    {
        public void SendEmail(string to, string message)
        {
            Console.WriteLine($"Sending email to {to}: {message}");
        }
        
    }
}