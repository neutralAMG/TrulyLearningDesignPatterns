public class ConcreteObserver2 : IObserver
{
    private readonly ConcreteObsevable observable;
    public ConcreteObserver2(ConcreteObsevable observable)
    {
        this.observable = observable;
    }
    public void Update()
    {
        Console.WriteLine("The data update the new data is: " + observable.Data);
    }
}