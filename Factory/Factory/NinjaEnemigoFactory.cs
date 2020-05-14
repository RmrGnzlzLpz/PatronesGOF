using Factory.Entities;
using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factory
{
    public class NinjaEnemigoFactory : IEnemigoFactory
    {
        public IEntity CrearEnemigo()
        {
            return new Ninja();
        }
    }
}
