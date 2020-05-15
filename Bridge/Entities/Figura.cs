using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Entities
{
    // Abstracción
    public abstract class Figura
    {
        protected IDibujo _dibujo;
        protected Figura(IDibujo dibujo)
        {
            _dibujo = dibujo;
        }
        public abstract string Dibujar();
        protected string DibujarCirculo(int x, int y, int radio)
        {
            return _dibujo.DibujarCirculo(x, y, radio);
        }
        protected string DibujarRectangulo(int inicioX, int inicioY, int finX, int finY)
        {
            return _dibujo.DibujarRectangulo(inicioX, inicioY, finX, finY);
        }
    }
}
