using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Entities
{
    public class Arbol : IClonable<Arbol>
    {
        public int Grosor { get; set; }
        public TipoArbol Tipo { get; set; }
        public Arbol ClonarProfundo()
        {
            return ClonarSuperficial();
        }

        public Arbol ClonarSuperficial()
        {
            return new Arbol
            {
                Grosor = Grosor,
                Tipo = Tipo
            };
        }
    }

    public enum TipoArbol
    {
        Alto = 0, Mediano = 1, Bajo = 2
    }
}
