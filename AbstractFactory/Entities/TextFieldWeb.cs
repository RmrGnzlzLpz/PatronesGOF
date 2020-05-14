using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities
{
    public class TextFieldWeb : ITextField
    {
        public bool Habilitado { get; set; } = true;
        public string Contenido { get; set; }

        public string Escribir(char e)
        {
            if (!Habilitado)
            {
                return("JavaScript: Input disabled");
            }
            Contenido += e.ToString();
            return($"JavaScript: Input <{Contenido}>");
        }
    }
}
