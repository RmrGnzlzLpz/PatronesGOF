using FactoryMethod.Entities;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    public class EnemigoFactory : IEnemigoFactory
    {
        public IEnemigo CrearEnemigo(TipoEnemigo tipo)
        {
            switch (tipo)
            {
                case TipoEnemigo.Mago:
                    return new Mago();
                case TipoEnemigo.Ninja:
                    return new Ninja();
                case TipoEnemigo.Samurai:
                    return new Samurai();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
