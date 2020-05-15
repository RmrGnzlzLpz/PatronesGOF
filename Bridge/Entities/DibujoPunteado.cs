using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Entities
{
    // Implementadores concretos
    public class DibujoPunteado : IDibujo
    {
        public string DibujarCirculo(int x, int y, int radio)
        {
            return("Dibujando Círculo Punteado");
        }

        public string DibujarRectangulo(int x1, int x2, int y1, int y2)
        {
            return("Dibujando Rectángulo Punteado");
        }
    }
}