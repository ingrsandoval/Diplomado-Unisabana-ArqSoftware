namespace GestionTareas
{
    public class CompletarTareaAccion : IAccion
    {
        private readonly SistemaGestorTareas _receptor;
        private readonly int _tareaId;

        public CompletarTareaAccion(SistemaGestorTareas receptor, int tareaId)
        {
            _receptor = receptor;
            _tareaId = tareaId;
        }

        public void Ejecutar() => _receptor.CompletarTarea(_tareaId);
        public void Deshacer()
        {
            _receptor.DesmarcarCompletada(_tareaId);
            Console.WriteLine($"DESHACER [Completar]: Tarea {_tareaId} marcada como no completada.");
        }
    }
}