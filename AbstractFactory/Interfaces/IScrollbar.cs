using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interfaces
{
    public interface IScrollbar
    {
        bool Habilitado { get; set; }
        bool PuedeSubir { get; set; }
        bool PuedeBajar { get; set; }
        string Subir();
        string Bajar();
    }
}
