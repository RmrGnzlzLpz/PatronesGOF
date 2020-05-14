using Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Entities
{
    public class Mago : Entity
    {
        public override void Actualizar()
        {
            Console.WriteLine($"Actualizando mago lvl {Nivel}...");
        }
    }
}
