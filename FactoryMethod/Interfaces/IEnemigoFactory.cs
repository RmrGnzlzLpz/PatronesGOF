using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Interfaces
{
    public interface IEnemigoFactory
    {
        IEnemigo CrearEnemigo(TipoEnemigo tipo);
    }

    public enum TipoEnemigo
    {
        Mago = 0, Samurai = 1, Ninja = 2
    }
}
