namespace NotificacionClientes;

public class NotificadorEmail : NotificadorDecorador
{
    public NotificadorEmail(INotificador notificador) : base(notificador) { }

    public override void Enviar(string mensaje)
    {
        base.Enviar(mensaje);
        Console.WriteLine($"Enviando por email: {mensaje}");
    }
}