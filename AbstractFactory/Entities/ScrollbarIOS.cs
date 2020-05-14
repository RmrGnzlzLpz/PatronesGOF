using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities
{
    public class ScrollbarIOS : IScrollbar
    {
        public bool Habilitado { get; set; } = true;
        public bool PuedeSubir { get; set; } = false;
        public bool PuedeBajar { get; set; } = true;

        public string Bajar()
        {
            if (PuedeBajar)
            {
                return("IOS: Bajando");
            }
            else
            {
                return("IOS: Fin de pantalla");
            }
        }

        public string Subir()
        {
            if (PuedeSubir)
            {
                return("IOS: Subiendo");
            }
            else
            {
                return("IOS: Inicio de pantalla");
            }
        }
    }
}
