namespace GestionTareas
{
    // --- Comandos Concretos ---
    public class CrearTareaAccion : IAccion
    {
        private readonly SistemaGestorTareas _receptor;
        private readonly string _descripcionTarea;
        private Tarea? _tareaCreada;

        public CrearTareaAccion(SistemaGestorTareas receptor, string descripcion)
        {
            _receptor = receptor;
            _descripcionTarea = descripcion;
        }

        public void Ejecutar() => _tareaCreada = _receptor.CrearTarea(_descripcionTarea);
        public void Deshacer()
        {
            if (_tareaCreada != null)
            {
                _receptor.EliminarTarea(_tareaCreada.Id);
                Console.WriteLine($"DESHACER [Crear]: Tarea {_tareaCreada.Id} eliminada.");
            }
        }
    }
}