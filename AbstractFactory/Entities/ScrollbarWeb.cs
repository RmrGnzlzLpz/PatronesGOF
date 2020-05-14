using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities
{
    public class ScrollbarWeb : IScrollbar
    {
        public bool Habilitado { get; set; } = true;
        public bool PuedeSubir { get; set; } = false;
        public bool PuedeBajar { get; set; } = true;

        public string Bajar()
        {
            if (PuedeBajar)
            {
                return("JavaScript: Bajando");
            }
            else
            {
                return("JavaScript: Fin de pantalla");
            }
        }

        public string Subir()
        {
            if (PuedeSubir)
            {
                return("JavaScript: Subiendo");
            }
            else
            {
                return("JavaScript: Inicio de pantalla");
            }
        }
    }
}
