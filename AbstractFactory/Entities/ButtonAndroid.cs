using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities
{
    public class ButtonAndroid : IButton
    {
        public bool Hablitado { get; set; } = true;
        public string Color { get; set; } = "Gris";
        public string Accion { get; set; } = "Enviar";

        public string Presionar()
        {
            if (Hablitado)
            {
                Color = "Gris Claro";
                Hablitado = false;
                return($"Android: Ejecutando {Accion}.");
            }
            else
            {
                Color = "Gris Claro";
                return($"Android: Disabled {Accion}.");
            }
        }
    }
}
