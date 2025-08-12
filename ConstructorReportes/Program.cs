using System;
using ConstructorReportes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Patron de diseño Creacional -> constructor ---");
        Console.WriteLine();
        Console.WriteLine("--- Construyendo un reporte completo ---");
        // Ejemplo 1: Construir un reporte completo
        var reporteCompleto = new ReportePDF.ReportePDFBuilder()
            .WithPortada("Banco XYZ - Juan Pérez")
            .WithEstadisticos("Estadísticos de Inversión 2024")
            .WithTablaMovimientos("Lista de transacciones de junio")
            .WithAnalisisTendencias("Proyección de crecimiento")
            .WithPieDePagina("Asesor 12345")
            .Build();

        reporteCompleto.Mostrar();
        Console.WriteLine("\n");

        Console.WriteLine("--- Construyendo un reporte básico ---");
        // Ejemplo 2: Construir un reporte básico sin todos los datos
        var reporteBasico = new ReportePDF.ReportePDFBuilder()
            .WithPortada("Banco XYZ - Ana Gómez")
            .WithEstadisticos("Estadísticos de Ahorro 2024")
            .WithPieDePagina("Asesor 67890")
            .Build(); // Se omiten las otras secciones

        reporteBasico.Mostrar();
        Console.WriteLine("\n");

        Console.WriteLine("--- Construyendo un reporte con lógica dinámica ---");
        // Ejemplo 3: Construcción condicional (con lógica dinámica)
        bool clienteTieneDatosSuficientes = true; // Simulación de una condición
        var builderDinamico = new ReportePDF.ReportePDFBuilder()
            .WithPortada("Banco XYZ - Carlos Sánchez")
            .WithTablaMovimientos("Transacciones del mes");

        if (clienteTieneDatosSuficientes)
        {
            builderDinamico.WithAnalisisTendencias("Análisis detallado");
        }
        var reporteDinamico = builderDinamico.Build();

        reporteDinamico.Mostrar();
        Console.WriteLine("\n");

        Console.WriteLine("--- Intentando construir un reporte inválido ---");
        // Ejemplo 4: Intentar construir un reporte inválido (sin portada)
        try
        {
            var builderInvalido = new ReportePDF.ReportePDFBuilder();
            var reporteInvalido = builderInvalido.Build();
            reporteInvalido.Mostrar();
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}