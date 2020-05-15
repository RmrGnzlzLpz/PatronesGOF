using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Entities
{
    // Abstracción refinada
    public class Rectangulo : Figura
    {
        public int InicioX, InicioY, FinX, FinY;
        public Rectangulo(IDibujo dibujo, int inicioX, int inicioY, int finX, int finY) : base(dibujo)
        {
            InicioX = inicioX;
            InicioY = inicioY;
            FinX = finX;
            FinY = finY;
        }
        public override string Dibujar()
        {
            return _dibujo.DibujarRectangulo(InicioX, InicioY, FinX, FinY);
        }
    }
}
