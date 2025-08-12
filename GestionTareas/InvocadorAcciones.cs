namespace GestionTareas
{
    // --- Invocador ---
    public class InvocadorAcciones
    {
        private readonly Stack<IAccion> _historial = new();

        public void EjecutarAccion(IAccion accion)
        {
            accion.Ejecutar();
            _historial.Push(accion);
        }

        public void DeshacerUltimaAccion()
        {
            if (_historial.Count > 0)
            {
                var ultimaAccion = _historial.Pop();
                ultimaAccion.Deshacer();
            }
            else
            {
                Console.WriteLine("No hay acciones que deshacer.");
            }
        }
    }
}