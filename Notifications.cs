namespace Notifications;
public class Notification
{
   public virtual void Send()
    {
        Console.WriteLine("Sending notification...");    
    }
}

public class EmailNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending email notification...");
    }
}

public class SmsNotifications : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending SMS notification...");
    }
}
public class PushNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending push notification...");
    }
}
