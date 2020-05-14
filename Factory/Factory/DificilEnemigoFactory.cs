using Factory.Entities;
using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factory
{
    public class DificilEnemigoFactory : IEnemigoFactory
    {
        public IEntity CrearEnemigo()
        {
            IEntity enemigo;
            double numeroRandom = Program.random.NextDouble();

            if (numeroRandom > 0.80)
            {
                enemigo = new Mago {
                    Energia = Convert.ToInt32(numeroRandom * 800) + 80,
                    Vida = Convert.ToInt32(numeroRandom * 1000) + 100,
                    Nivel = Convert.ToInt32(numeroRandom * 10) + 1,
                };
            }
            else if (numeroRandom > 0.50)
            {
                enemigo = new Samurai
                {
                    Energia = Convert.ToInt32(numeroRandom * 400) + 80,
                    Vida = Convert.ToInt32(numeroRandom * 600) + 100,
                    Nivel = Convert.ToInt32(numeroRandom * 15) + 1,
                };
            }
            else
            {
                enemigo = new Ninja
                {
                    Energia = Convert.ToInt32(numeroRandom * 1000) + 80,
                    Vida = Convert.ToInt32(numeroRandom * 400) + 100,
                    Nivel = Convert.ToInt32(numeroRandom * 12) + 1,
                };
            }
            return enemigo;
        }
    }
}
