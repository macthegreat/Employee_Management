namespace AbNotify;
abstract class NotificationAb
{
    public string Recepient {get; set;}


    public NotificationAb (string recepient)
    {
        Recepient = recepient;
    }
    public void ShowRecipient()
    {
       Console.WriteLine($"Recepient: {Recepient}");
    }
    public abstract void Send();
}

class EmailNotificationAb : NotificationAb
{
    public EmailNotificationAb(string recepient) : base(recepient)
    {
        Console.WriteLine($"Recipient: {Recepient}");
    }
    public override void Send()
    {
        Console.WriteLine($"Sending email to {Recepient} ");
    }
}
class SmsNotificationAb : NotificationAb
{
    public SmsNotificationAb(string recepient) : base(recepient)
    {
        
    }
    public override void Send()
    {
        Console.WriteLine($"Sending Sms to {Recepient}");
    }
}
class PushNotificationAb : NotificationAb
{
    public PushNotificationAb (string recepient) : base(recepient)
    {
    }
    public override void Send()
    {
       Console.WriteLine($"Sending push notification to {Recepient} ");
    }
}