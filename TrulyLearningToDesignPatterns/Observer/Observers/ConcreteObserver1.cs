public class ConcreteObserver1 : IObserver
{
    private readonly ConcreteObsevable observable;
    public ConcreteObserver1(ConcreteObsevable observable)
    {
        this.observable = observable;
    }
    public void Update()
    {
        Console.WriteLine("The Data updated the new data is: " + observable.Data);
    }
}