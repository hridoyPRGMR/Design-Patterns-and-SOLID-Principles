namespace OOPS.src.Coupling
{
    public class  SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending SMS with message: " + message);
        }
    }
}