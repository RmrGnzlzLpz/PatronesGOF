using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Entities
{
    // Abstracción refinada
    public class Circulo : Figura
    {
        public int X, Y, Radio;
        public Circulo(IDibujo dibujo, int x, int y, int radio) : base(dibujo)
        {
            X = x;
            Y = y;
            Radio = radio;
        }
        public override string Dibujar()
        {
            return _dibujo.DibujarCirculo(X, Y, Radio);
        }
    }
}
