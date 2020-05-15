using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Entities
{
    public class Camara : IClonable<Camara>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Camara ClonarSuperficial()
        {
            return new Camara
            {
                X = X, Y = Y, Z = Z
            };
        }
        public Camara ClonarProfundo()
        {
            return new Camara
            {
                X = X, Y = Y, Z = Z
            };
        }
    }
}
