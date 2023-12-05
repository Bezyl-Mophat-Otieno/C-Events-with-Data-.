namespace DataCarryingEvents;

public class Video
{

    public event EventHandler<VideoEvent> VideoEventGenerator ;

    public void PublishVideo(){

        Console.WriteLine("Publishing .....");

        Thread.Sleep(3000);

        OnVideoPublish("C# events and delegates");
    }

    protected virtual void OnVideoPublish(string videoTitle){
        var data = new Data (){title = videoTitle};
        if(VideoEventGenerator != null){
            VideoEventGenerator(this,new VideoEvent(){data=data});
        }
    }

}
