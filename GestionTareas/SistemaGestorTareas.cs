namespace GestionTareas
{
    // --- Receptor: Lógica de Negocio ---
    public class SistemaGestorTareas
    {
        private readonly Dictionary<int, Tarea> _tareas = new();
        private int _proximoId = 1;

        public Tarea CrearTarea(string descripcion)
        {
            var nuevaTarea = new Tarea(_proximoId++, descripcion);
            _tareas.Add(nuevaTarea.Id, nuevaTarea);
            Console.WriteLine($"✅ Tarea CREADA: {nuevaTarea}");
            return nuevaTarea;
        }

        public void EditarTarea(int id, string nuevaDescripcion)
        {
            if (_tareas.TryGetValue(id, out var tarea))
            {
                string descripcionAnterior = tarea.Descripcion;
                tarea.Descripcion = nuevaDescripcion;
                Console.WriteLine($"✏️ Tarea EDITADA (ID: {id}): '{descripcionAnterior}' -> '{nuevaDescripcion}'");
            }
        }

        public void CompletarTarea(int id)
        {
            if (_tareas.TryGetValue(id, out var tarea) && !tarea.Completada)
            {
                tarea.Completada = true;
                Console.WriteLine($"✔️ Tarea COMPLETADA: {tarea}");
            }
        }

        public void EliminarTarea(int id)
        {
            if (_tareas.Remove(id, out var tareaEliminada))
            {
                Console.WriteLine($"❌ Tarea ELIMINADA: {tareaEliminada}");
            }
        }

        // --- Métodos de soporte para 'Deshacer' ---
        public void AgregarTarea(Tarea tarea) => _tareas.Add(tarea.Id, tarea);
        public void DesmarcarCompletada(int id)
        {
            if (_tareas.TryGetValue(id, out var tarea)) tarea.Completada = false;
        }

        public void MostrarTareas()
        {
            Console.WriteLine("\n--- LISTA DE TAREAS ACTUAL ---");
            if (_tareas.Count == 0) Console.WriteLine("No hay tareas pendientes.");
            else foreach (var tarea in _tareas.Values) Console.WriteLine(tarea);
            Console.WriteLine("--------------------------------\n");
        }
    }
}