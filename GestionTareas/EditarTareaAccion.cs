namespace GestionTareas
{
    public class EditarTareaAccion : IAccion
    {
        private readonly SistemaGestorTareas _receptor;
        private readonly int _tareaId;
        private readonly string _nuevaDescripcion;
        private readonly string _descripcionAnterior;

        public EditarTareaAccion(SistemaGestorTareas receptor, Tarea tareaAEditar, string nuevaDescripcion)
        {
            _receptor = receptor;
            _tareaId = tareaAEditar.Id;
            _descripcionAnterior = tareaAEditar.Descripcion;
            _nuevaDescripcion = nuevaDescripcion;
        }

        public void Ejecutar() => _receptor.EditarTarea(_tareaId, _nuevaDescripcion);
        public void Deshacer()
        {
            _receptor.EditarTarea(_tareaId, _descripcionAnterior);
            Console.WriteLine($"DESHACER [Editar]: Tarea {_tareaId} restaurada a '{_descripcionAnterior}'.");
        }
    }
}