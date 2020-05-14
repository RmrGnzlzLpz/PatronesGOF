using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Entities
{
    public abstract class Enemigo : IEnemigo
    {
        public int Vida { get; set; }
        public int Energia { get; set; }
        public int Fuerza { get; set; }
        public int Velocidad { get; set; }

        public virtual void Actualizar()
        {
            Console.WriteLine("Redibujando Enemigo...");
        }
        public virtual void Atacar()
        {
            if (Energia < 10)
            {
                Console.WriteLine("El personaje está cansado.");
            } else
            {
                Energia -= 10;
            }
        }
        public virtual void Caminar()
        {
            if (Energia == 0)
            {
                Console.WriteLine("El personaje está cansado.");
            } else
            {
                Energia -= 1;
            }
        }
        public virtual void Correr()
        {
            if (Energia < 10)
            {
                Console.WriteLine("El personaje está cansado.");
            }
            else
            {
                Energia -= 10;
            }
        }
        public virtual void Saltar()
        {
            if (Energia > 2)
            {
                Energia -= 2;
                if (Velocidad > 0) Velocidad -= 1;
                Console.WriteLine($"El mundo se ve más pequeño desde aquí. Energia: {Energia}");
            } else
            {
                Console.WriteLine("El personaje no puede saltar.");
            }

        }
    }
}
