using System;
using System.Text;

namespace ConstructorReportes
{
    public sealed class ReportePDF
    {
        public string Portada { get; }
        public string Estadisticos { get; }
        public string TablaMovimientos { get; }
        public string AnalisisTendencias { get; }
        public string PieDePagina { get; }

        private ReportePDF(ReportePDFBuilder builder)
        {
            Portada = builder.Portada;
            Estadisticos = builder.Estadisticos;
            TablaMovimientos = builder.TablaMovimientos;
            AnalisisTendencias = builder.AnalisisTendencias;
            PieDePagina = builder.PieDePagina;
        }

        public void Mostrar()
        {
            var sb = new StringBuilder();
            sb.AppendLine("--- Generando Reporte PDF ---");
            if (Portada != null) sb.AppendLine($"Sección: {Portada}");
            if (Estadisticos != null) sb.AppendLine($"Sección: {Estadisticos}");
            if (TablaMovimientos != null) sb.AppendLine($"Sección: {TablaMovimientos}");
            if (AnalisisTendencias != null) sb.AppendLine($"Sección: {AnalisisTendencias}");
            if (PieDePagina != null) sb.AppendLine($"Sección: {PieDePagina}");
            sb.AppendLine("--- Reporte PDF generado exitosamente ---");

            Console.WriteLine(sb.ToString());
        }

        public class ReportePDFBuilder
        {
            public string Portada { get; private set; }
            public string Estadisticos { get; private set; }
            public string TablaMovimientos { get; private set; }
            public string AnalisisTendencias { get; private set; }
            public string PieDePagina { get; private set; }

            public ReportePDFBuilder WithPortada(string portada)
            {
                Portada = $"Portada con el logotipo y nombre del cliente: {portada}";
                return this;
            }

            public ReportePDFBuilder WithEstadisticos(string estadisticos)
            {
                Estadisticos = $"Estadísticos: {estadisticos}";
                return this;
            }

            public ReportePDFBuilder WithTablaMovimientos(string tablaMovimientos)
            {
                TablaMovimientos = $"Tabla de movimientos recientes: {tablaMovimientos}";
                return this;
            }

            public ReportePDFBuilder WithAnalisisTendencias(string analisisTendencias)
            {
                AnalisisTendencias = $"Análisis de tendencias: {analisisTendencias}";
                return this;
            }

            public ReportePDFBuilder WithPieDePagina(string pieDePagina)
            {
                PieDePagina = $"Pie de página con contador del asesor: {pieDePagina}";
                return this;
            }

            private void Validar()
            {
                if (string.IsNullOrEmpty(Portada))
                {
                    throw new InvalidOperationException("El reporte debe tener al menos una portada.");
                }
            }

            public ReportePDF Build()
            {
                Validar();
                return new ReportePDF(this);
            }
        }
    }
}