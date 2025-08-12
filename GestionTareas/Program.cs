using System;
using System.Collections.Generic;

namespace GestionTareas
{

    // --- Cliente: Punto de Entrada ---
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("### Patron de diseño COMPORTAMIENTO -> COMMAND ###");
            Console.WriteLine();
            var gestor = new SistemaGestorTareas();
            var invocador = new InvocadorAcciones();

            Console.WriteLine("### INICIO DE OPERACIONES ###");

            var tarea1 = new Tarea(1, "Diseñar Diagrama UML");
            var tarea2 = new Tarea(2, "Codificar la solución en C#");

            invocador.EjecutarAccion(new CrearTareaAccion(gestor, tarea1.Descripcion));
            invocador.EjecutarAccion(new CrearTareaAccion(gestor, tarea2.Descripcion));
            gestor.MostrarTareas();

            invocador.EjecutarAccion(new EditarTareaAccion(gestor, tarea1, "Diseñar y validar Diagrama UML"));
            invocador.EjecutarAccion(new CompletarTareaAccion(gestor, tarea2.Id));
            gestor.MostrarTareas();

            Console.WriteLine("\n### INICIO DE OPERACIONES DE DESHACER ###");

            invocador.DeshacerUltimaAccion();
            gestor.MostrarTareas();

            invocador.DeshacerUltimaAccion();
            gestor.MostrarTareas();
        }
    }
}