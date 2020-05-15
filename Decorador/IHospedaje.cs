using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public interface IHospedaje
    {
        string Descripcion { get; set; }
        string Tipo { get; set; }
        double Costo { get; set; }
    }
}
