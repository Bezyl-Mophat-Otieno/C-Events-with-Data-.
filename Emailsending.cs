namespace DataCarryingEvents;

public class Emailsending
{

    public void OnVideoPublish(object source , VideoEvent eventargs){
        Console.WriteLine($"Email sending .....\t {eventargs.data.title}");
    }

}
