namespace SOLID.SRP;

public class UserService
{
    private readonly EmailSender _emailSender;

    public UserService(EmailSender emailSender)
    {
        _emailSender = emailSender; 
    }

    public void RegisterUser(User user)
    {
        // Logic to register the user (e.g., save to database)
        Console.WriteLine($"User {user.Username} registered with email {user.Email}");

        // Send welcome email
        _emailSender.SendEmail(user.Email, "Welcome to our service!");
    }
}