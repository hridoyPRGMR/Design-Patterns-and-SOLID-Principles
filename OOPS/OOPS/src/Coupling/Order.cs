namespace OOPS.src.Coupling
{
    public class Order
    {
        private readonly INotificationService _notificationService;

        public Order(INotificationService notificationService)
        {
            // Dependency Injection
            _notificationService = notificationService;
        }
        
        public void PlaceOrder()
        {
            // Logic to place the order
            Console.WriteLine("Order placed successfully.");
            _notificationService.SendNotification("Your order has been placed successfully.");
        }
    }
}