namespace OOPS.src.Coupling
{
    public class EmailSender : INotificationService
    {

        public void SendNotification(string message)
        {
            Console.WriteLine("Sending email with message: " + message);
        }
    }
}