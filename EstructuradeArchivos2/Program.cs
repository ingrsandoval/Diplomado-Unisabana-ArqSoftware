using System;

namespace EstructuradeArchivos2
{

    public class OperatingSystemSimulator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("======= ## Patron de diseño ESTRUCTURAL - COMPOSITE ## =======");
            // 1. Crear la estructura de archivos y carpetas
            var root = new Folder("C:");
            var documents = new Folder("Documentos");
            var music = new Folder("Música");

            var doc1 = new File("tesis_final.docx", 2048);
            var doc2 = new File("presupuesto.xlsx", 1024);

            var song1 = new File("queen_bohemian_rhapsody.mp3", 5800);
            var artistFolder = new Folder("The Beatles");
            var song2 = new File("let_it_be.mp3", 4200);

            // 2. Construir el árbol (la composición)
            root.AddComponent(documents);
            root.AddComponent(music);

            documents.AddComponent(doc1);
            documents.AddComponent(doc2);

            music.AddComponent(song1);
            music.AddComponent(artistFolder);
            artistFolder.AddComponent(song2);

            // 3. Demostrar las operaciones uniformes
            Console.WriteLine("======= IMPRESIÓN JERÁRQUICA =======");
            root.Print("");

            Console.WriteLine("\n======= CÁLCULO DE TAMAÑO =======");
            // El cliente no necesita saber si 'documents' es archivo o carpeta, solo accede a la propiedad Size
            Console.WriteLine($"Tamaño de la carpeta 'Documentos': {documents.Size} bytes");
            Console.WriteLine($"Tamaño de la carpeta 'Música': {music.Size} bytes");
            Console.WriteLine($"Tamaño total del disco 'C:': {root.Size} bytes");
            Console.WriteLine($"Tamaño de un archivo individual 'tesis_final.docx': {doc1.Size} bytes");

            Console.WriteLine("\n======= OPERACIÓN DE BORRADO (SIMULACIÓN) =======");
            // Se puede llamar a Delete() sobre una carpeta entera
            documents.Delete();

            Console.WriteLine("\n======= OPERACIÓN DE RENOMBRADO (SIMULACIÓN) =======");
            song1.Rename("Queen - Bohemian Rhapsody (Remastered).mp3");
        }
    }
}