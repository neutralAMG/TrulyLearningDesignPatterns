public class MandarMensajes
{
    public string? sender;

    public void MandarCorreo(string mensaje)
    {

        Console.WriteLine($"{sender} te acaba de mandar un mensaje por correo, dice {mensaje}");
        //Utiliza un sender para mandar un mensaje
        //Logica para mandar Correo
    }
    public void MandarWs(string mensaje)
    {
        Console.WriteLine($"{sender} te acaba de mandar un mensaje por Whatsapp, dice {mensaje}");
        //Utiliza un sender para mandar un mensaje
        //Logica para mandar ws
    }

}

//Algo excecivo pero de esta forma podriamos mandar
//cualquier tipo de mensaje que necesitemos mandar