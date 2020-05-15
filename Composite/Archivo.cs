using System;

namespace Composite
{
    // Hoja o Leaf
    public class Archivo : IFile
    {
        public string Nombre { get; set; }

        public Archivo(string nombre)
        {
            Nombre = nombre;
        }
        public string Ls()
        {
            return($"- {Nombre}\n");
        }
    }
}
