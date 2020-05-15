using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public class VistaAlMar : Decorador
    {
        public VistaAlMar(IHospedaje hospedaje) : base(hospedaje)
        {
            Hospedaje.Descripcion += " (Vista Al Mar)";
            Hospedaje.Costo += 100000;
        }
    }
}
