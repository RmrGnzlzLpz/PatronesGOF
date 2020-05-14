using Factory.Abstract;
using Factory.Entities;
using Factory.Factory;
using Factory.Interfaces;
using System;
using System.Collections.Generic;

namespace Factory
{
    class Program
    {
        public static readonly Random random = new Random();
        public static List<IEntity> Entities { get; set; }
        public static bool PuedeGenerarEnemigos { get; set; }

        static void Main(string[] args)
        {
            PuedeGenerarEnemigos = true;
            Entities = new List<IEntity>();

            // Podemos cambiar la forma en que queremos generar los enemigos.
            //IEnemigoFactory factory = new RandomEnemigoFactory();
            IEnemigoFactory factory = new DificilEnemigoFactory();

            for (int i = 0; i < 100; i++)
            {
                Logica(factory);
            }
            // Más lógica...
            foreach (var enemy in Entities)
            {
                enemy.Actualizar();
            }
            // ...
            Console.ReadKey();
        }

        static void Logica(IEnemigoFactory factory)
        {
            // Lógica adicional
            if (PuedeGenerarEnemigos)
            {
                IEntity enemigo = factory.CrearEnemigo();
                Entities.Add(enemigo);
            }
            // Más lógica aquí
        }
    }
}
