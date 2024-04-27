public class PersonaWhitOutRefactoring
{
    private string Nombre;
    private string Edad;
    private string Direccion;
    private string CorreoElectronico;
    public void EnviarCorreoElectronico(string mensaje)
    {
        //Logica mandar Correo
    }
    public void Imprimir()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Direccion: {Direccion}");
        Console.WriteLine($"Correo electronico: {CorreoElectronico}");
    }
}

//Clase sin refactorizar
//Esta violenta el spr porque realiza mas de una accion
//Esta clase no deberia de ser la responsable de enviar el correo
//Ya que la funcionalidad de mandar correo no deberia de depender de esta clase
//Ya que si se decea cambiar la logica para mandar el correo se deberia de cambiar la clase persona en si