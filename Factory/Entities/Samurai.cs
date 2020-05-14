using Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Entities
{
    public class Samurai : Entity
    {
        public override void Actualizar()
        {
            Console.WriteLine($"Actualizando samurai nivel {Nivel}...");
        }
    }
}
