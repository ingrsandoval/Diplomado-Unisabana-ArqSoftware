namespace GestionTareas
{
    // --- Clase Modelo: Tarea ---
    public class Tarea
    {
        public int Id { get; private set; }
        public string Descripcion { get; set; }
        public bool Completada { get; set; }

        public Tarea(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
            Completada = false;
        }

        public override string ToString()
        {
            return $"Tarea(Id: {Id}, Descripcion: '{Descripcion}', Completada: {Completada})";
        }
    }
}