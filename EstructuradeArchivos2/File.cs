using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuradeArchivos2
{
    /// <summary>
    /// La clase Hoja (File) representa los objetos finales de una composición.
    /// Un archivo no puede tener sub-elementos.
    /// </summary>
    public class File : IFileSystemComponent
    {
        private string _name;
        private readonly long _size; // en bytes

        public File(string name, long size)
        {
            _name = name;
            _size = size;
        }

        // En C#, las propiedades son la forma idiomática de exponer datos.
        public long Size => _size;

        public void Print(string prefix)
        {
            // Usamos interpolación de strings ($), que es más común en C#.
            Console.WriteLine($"{prefix}{_name} ({Size} bytes)");
        }

        public void Delete()
        {
            Console.WriteLine($"Eliminando archivo: {_name}");
            // Aquí iría la lógica real de borrado.
        }

        public void Rename(string newName)
        {
            Console.WriteLine($"Renombrando archivo '{_name}' a '{newName}'");
            _name = newName;
        }
    }
}
