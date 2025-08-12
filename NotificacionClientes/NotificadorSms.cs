namespace NotificacionClientes;

public class NotificadorSms : NotificadorDecorador
{
    public NotificadorSms(INotificador notificador) : base(notificador) { }

    public override void Enviar(string mensaje)
    {
        base.Enviar(mensaje);
        Console.WriteLine($"Enviando por SMS: {mensaje}");
    }
}