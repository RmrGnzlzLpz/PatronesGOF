using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Abstract
{
    public abstract class Entity : IEntity
    {
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int Energia { get; set; }
        public Entity()
        {
            Nivel = 1;
            Vida = 100;
            Energia = 80;
        }

        public void SubirNivel()
        {
            Nivel++;
            Vida += 100;
            Energia += 80;
        }

        public virtual void Actualizar()
        {
            Console.WriteLine("Actualizando enemigo.");
        }
    }
}
