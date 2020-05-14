using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interfaces
{
    public interface ITextField
    {
        bool Habilitado { get; set; }
        string Contenido { get; set; }
        string Escribir(char e);
    }
}
