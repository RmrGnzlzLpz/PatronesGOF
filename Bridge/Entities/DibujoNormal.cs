using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Entities
{
    // Implementadores concretos
    public class DibujoNormal : IDibujo
    {
        public string DibujarCirculo(int x, int y, int radio)
        {
            return("Dibujando Círculo Normal");
        }

        public string DibujarRectangulo(int x1, int x2, int y1, int y2)
        {
            return("Dibujando Rectángulo Normal");
        }
    }
}
