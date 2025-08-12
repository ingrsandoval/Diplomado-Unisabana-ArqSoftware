namespace NotificacionClientes;

public class NotificadorWhatsApp : NotificadorDecorador
{
    public NotificadorWhatsApp(INotificador notificador) : base(notificador) { }

    public override void Enviar(string mensaje)
    {
        base.Enviar(mensaje);
        Console.WriteLine($"Enviando por WhatsApp: {mensaje}");
    }
}