using Factory.Entities;
using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factory
{
    public class RandomEnemigoFactory : IEnemigoFactory
    {
        public IEntity CrearEnemigo()
        {
            IEntity enemigo;
            double numeroRandom = Program.random.NextDouble();

            if (numeroRandom > 0.66)
            {
                enemigo = new Mago();
            }
            else if (numeroRandom > 0.33)
            {
                enemigo = new Samurai();
            }
            else
            {
                enemigo = new Ninja();
            }
            return enemigo;
        }
    }
}
