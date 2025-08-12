namespace GestionTareas
{
    // --- Interfaz Command ---
    public interface IAccion
    {
        void Ejecutar();
        void Deshacer();
    }
}