using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Composite
{
    // Composite
    public class Directorio : IFile
    {
        public string Nombre { get; set; }
        public List<IFile> Files { get; set; }

        public Directorio(string nombre)
        {
            Nombre = nombre;
            Files = new List<IFile>();
        }

        public void Add(IFile file)
        {
            Files.Add(file);
        }

        public string Ls()
        {
            string respuesta = $"/{Nombre}\n";
            foreach(var file in Files)
            {
                respuesta += file.Ls();
            }
            return respuesta;
        }
    }
}
