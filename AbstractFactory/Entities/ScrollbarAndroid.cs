using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities
{
    public class ScrollbarAndroid : IScrollbar
    {
        public bool Habilitado { get; set; } = true;
        public bool PuedeSubir { get; set; } = false;
        public bool PuedeBajar { get; set; } = true;

        public string Bajar()
        {
            if (PuedeBajar)
            {
                return("Android: Bajando");
            } 
            return("Android: Fin de pantalla");
        }

        public string Subir()
        {
            if (PuedeSubir)
                return("Android: Subiendo");

            return("Android: Inicio de pantalla");
        }
    }
}
