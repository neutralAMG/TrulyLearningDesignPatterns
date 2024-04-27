

using System.Timers;

public class ConcreteObsevable : IObservable
{
    public ConcreteObsevable()
    {
        Observers = new List<IObserver>();
        timer = new System.Timers.Timer(2000);
    }
    public System.Timers.Timer timer;
    private List<IObserver> Observers { get; set; }
    public int Data { get; set; }
    public void Add(IObserver observer)
    {
        Observers.Add(observer);
    }
    public void Remove(IObserver observer)
    {
        Observers.Remove(observer);
    }
    public void next()
    {
        foreach (var observer in Observers)
        {
            observer.Update();
        }
    }


    public void GetNewData(object sorce, ElapsedEventArgs e)
    {
        this.Data = new Random().Next(100000) + 1;
        next();

    }
    public void stopTimer()
    {
        timer.Stop();
        timer.Dispose();
    }


}