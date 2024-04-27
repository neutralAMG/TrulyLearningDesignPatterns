// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Refactoring challenge halenge test code
void TryRefactoringChallenge()
{
    PersonaRefactorized personaRefactorizedQueMandaCorreo = new PersonaRefactorized(new MandarMensajes());
    PersonaRefactorized personaRefactorizedQueMandaWs = new PersonaRefactorized(new MandarMensajes());
    personaRefactorizedQueMandaCorreo.mandarMensajes.MandarCorreo("hola");
    personaRefactorizedQueMandaWs.mandarMensajes.MandarWs("klk");
}


// Observer Pattern Test code
void TryObserverPattern()
{

    ConcreteObsevable concreteObsevable = new ConcreteObsevable();
    ConcreteObserver2 concreteObserver2 = new ConcreteObserver2(concreteObsevable);
    ConcreteObserver1 concreteObserver1 = new ConcreteObserver1(concreteObsevable);

    concreteObsevable.Add(concreteObserver1);
    concreteObsevable.Add(concreteObserver2);


    concreteObsevable.timer.Elapsed += concreteObsevable.GetNewData;
    concreteObsevable.timer.AutoReset = true;
    concreteObsevable.timer.Enabled = true;

    Console.ReadLine();

    concreteObsevable.stopTimer();

}

TryObserverPattern();
