using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AbstractFactory.Entities
{
    public class ButtonWeb : IButton
    {
        public bool Hablitado { get; set; } = true;
        public string Color { get; set; } = "Blanco";
        public string Accion { get; set; } = "Enviar";

        public string Presionar()
        {
            if (Hablitado)
            {
                Color = "Azul";
                return($"JavaScript: Ejecutando {Accion}.");
            } 
            Color = "Gris";
            return($"JavaScript: Disabled {Accion}.");
        }
    }
}
