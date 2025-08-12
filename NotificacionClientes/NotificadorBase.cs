namespace NotificacionClientes;

public class NotificadorBase : INotificador
{
    public void Enviar(string mensaje)
    {
        Console.WriteLine($"Iniciando proceso de notificación: {mensaje}");
    }
}