using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interfaces
{
    public interface IButton
    {
        bool Hablitado { get; set; }
        string Color { get; set; }
        string Accion { get; set; }
        string Presionar();
    }
}
