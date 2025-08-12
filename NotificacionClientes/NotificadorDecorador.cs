namespace NotificacionClientes;

public abstract class NotificadorDecorador : INotificador
{
    protected INotificador _notificador;

    public NotificadorDecorador(INotificador notificador)
    {
        _notificador = notificador;
    }

    public virtual void Enviar(string mensaje)
    {
        _notificador.Enviar(mensaje);
    }
}