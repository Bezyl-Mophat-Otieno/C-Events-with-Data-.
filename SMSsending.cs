namespace DataCarryingEvents;

public class SMSsending
{

    public void OnVideoPublish(object source , VideoEvent eventArgs){
        Console.WriteLine($"SMS sending ....\t {eventArgs.data.title}" );
    }

}
