using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Linq; // Necesario para usar LINQ (Sum)
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// La clase Compuesto (Folder) representa los componentes complejos que pueden
/// tener hijos. Delega el trabajo a sus hijos y "suma" el resultado.
/// </summary>
namespace EstructuradeArchivos2
{
    public class Folder : IFileSystemComponent
    {
        private string _name;
        // Es convención usar un guion bajo para los campos privados.
        private readonly List<IFileSystemComponent> _children = new List<IFileSystemComponent>();

        public Folder(string name)
        {
            _name = name;
        }

        public void AddComponent(IFileSystemComponent component)
        {
            _children.Add(component);
        }

        public void RemoveComponent(IFileSystemComponent component)
        {
            _children.Remove(component);
        }

        // La propiedad Size calcula el total recursivamente usando LINQ.
        public long Size => _children.Sum(component => component.Size);

        public void Print(string prefix)
        {
            Console.WriteLine($"{prefix}📁 {_name} (tamaño total: {Size} bytes)");

            // El bucle foreach es idéntico en sintaxis a Java.
            foreach (var component in _children)
            {
                component.Print($"{prefix}  |__ ");
            }
        }

        public void Delete()
        {
            Console.WriteLine($"Eliminando carpeta: {_name} y todo su contenido.");
            foreach (var component in _children)
            {
                component.Delete();
            }
            // Lógica para borrar la carpeta en sí.
        }

        public void Rename(string newName)
        {
            Console.WriteLine($"Renombrando carpeta '{_name}' a '{newName}'");
            _name = newName;
        }
    }
}