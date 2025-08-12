using NotificacionClientes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Patron de diseño ESTRUCTURAL -> Decorador ---");

        string mensaje = "¡Tu pedido ha sido completado con éxito!";

        // Caso 1: Notificación solo por email
        Console.WriteLine("--- Cliente que solo quiere notificaciones por email ---");
        INotificador notificadorEmail = new NotificadorEmail(new NotificadorBase());
        notificadorEmail.Enviar(mensaje);

        Console.WriteLine("\n-----------------------------------------------------");

        // Caso 2: Combinación de canales (email y WhatsApp)
        Console.WriteLine("--- Cliente que quiere notificaciones por email y WhatsApp ---");
        INotificador notificadorEmailWhatsApp = new NotificadorWhatsApp(new NotificadorEmail(new NotificadorBase()));
        notificadorEmailWhatsApp.Enviar(mensaje);

        Console.WriteLine("\n-----------------------------------------------------");

        // Caso 3: Combinación de tres canales (email, SMS y WhatsApp)
        Console.WriteLine("--- Cliente que quiere notificaciones por email, SMS y WhatsApp ---");
        INotificador notificadorCompleto = new NotificadorWhatsApp(new NotificadorSms(new NotificadorEmail(new NotificadorBase())));
        notificadorCompleto.Enviar(mensaje);
    }
}