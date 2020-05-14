using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities
{
    public class TextFieldIOS : ITextField
    {
        public bool Habilitado { get; set; } = true;
        public string Contenido { get; set; }

        public string Escribir(char e)
        {
            if (Habilitado)
            {
                Contenido += e.ToString();
                return($"IOS: Input <{Contenido}>");
            }
            else
            {
                return("IOS: Input disabled");
            }
        }
    }
}
