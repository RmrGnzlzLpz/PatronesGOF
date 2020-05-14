using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities
{
    public class ButtonIOS : IButton
    {
        public bool Hablitado { get; set; } = true;
        public string Color { get; set; } = "Blanco";
        public string Accion { get; set; } = "Enviar";

        public string Presionar()
        {
            if (Hablitado)
            {
                Color = "Gris";
                return ($"IOS: Ejecutando {Accion}.");
            }
            else
            {
                Color = "Gris Oscuro";
                return($"IOS: Disabled {Accion}.");
            }
        }
    }
}
