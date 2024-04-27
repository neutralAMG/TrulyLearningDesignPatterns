public class PersonaRefactorized
{

    public PersonaRefactorized(MandarMensajes mandarMensajes)
    {
        this.mandarMensajes = mandarMensajes;
        mandarMensajes.sender = CorreoElectronico;
    }
    public MandarMensajes mandarMensajes;
    private string Nombre = "Alex";
    private string Edad = "20";
    private string Direccion = "tu sabe";
    public string CorreoElectronico = "alex@gmail.com";
    public void Imprimir()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Direccion: {Direccion}");
        Console.WriteLine($"Correo electronico: {CorreoElectronico}");
    }
}