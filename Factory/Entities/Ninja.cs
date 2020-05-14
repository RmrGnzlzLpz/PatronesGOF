using Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Entities
{
    public class Ninja : Entity
    {
        public override void Actualizar()
        {
            Console.WriteLine($"Actualizando ninja nivel {Nivel}...");
        }
    }
}
