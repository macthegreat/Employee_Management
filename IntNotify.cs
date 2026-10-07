namespace IntNotify;
public interface INotifications{
    void Send(string mess);
}
public interface INotificationInfo
{
    string Recipient { get; set; }
    void Message(string response);
}


class EmailNotifications1 : INotifications,INotificationInfo
{
    public string Recipient {get; set;}
    public void Send(string mess)
    {
        Console.WriteLine($"Email sent: {mess}");
    }
    public void Message(string response)
    { 
        Recipient = response;
        Console.WriteLine($"Email sent to {Recipient}: Your account has been created.");
    }
}
class SmsNotifications1 : INotifications, INotificationInfo
{
    public string Recipient {get; set;}
    public void Send(string mess)
    {
        Console.WriteLine($"SMS sent: {mess}");
    }
     public void Message(string response)
    {
        Recipient = response;
        Console.WriteLine($"Sms sent to {Recipient}: Your account has been created.");
    }
}

class PushNotifications1 : INotifications, INotificationInfo
{
    public string Recipient {get; set;}
    public void Send(string mess)
    {
        Console.WriteLine($"Push notification sent: {mess}");
    }
     public void Message(string response)
    {
        Recipient = response;
        Console.WriteLine($"message pushed to {Recipient}: Your account has been created.");
    }
}