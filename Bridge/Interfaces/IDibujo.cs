using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Interfaces
{
    // Implementador
    public interface IDibujo
    {
        string DibujarCirculo(int x, int y, int radio);
        string DibujarRectangulo(int inicioX, int inicioY, int finX, int finY);
    }
}
