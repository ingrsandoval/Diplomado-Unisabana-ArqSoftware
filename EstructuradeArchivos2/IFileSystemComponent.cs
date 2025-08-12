using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuradeArchivos2
{
    /// <summary>
    /// La interfaz Componente (IFileSystemComponent) declara las operaciones comunes
    /// tanto para los objetos simples (File) como para los complejos (Folder).
    /// </summary>
    public interface IFileSystemComponent
    {
        /// <summary>
        /// Propiedad que obtiene el tamaño total del componente en bytes.
        /// Para un archivo, es su tamaño. Para una carpeta, es la suma de sus contenidos.
        /// </summary>
        long Size { get; }

        /// <summary>
        /// Imprime la estructura jerárquica del componente.
        /// </summary>
        /// <param name="prefix">El prefijo de indentación para mostrar la jerarquía.</param>
        void Print(string prefix);

        /// <summary>
        /// Elimina el componente.
        /// </summary>
        void Delete();

        /// <summary>
        /// Renombra el componente.
        /// </summary>
        /// <param name="newName">El nuevo nombre para el componente.</param>
        void Rename(string newName);
    }
}
