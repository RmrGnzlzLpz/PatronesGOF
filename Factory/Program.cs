using Factory.Abstract;
using Factory.Entities;
using Factory.Factory;
using Factory.Interfaces;
using System;
using System.Collections.Generic;

/*
 * Descripcion del problema:
 * Queremos que en nuestro videojuego se generen enemigos de diferentes maneras.
 * Algunos jugadores quieren que los enemigos generados sean mas dificiles, otros quieren que se generen de modo normal.
 * Para ello construimos factorías que nos permiten generar enemigos de diferentes formas, incluso podríamos generar
 * más factorías para generar solo Ninjas, o solo Samurais; y el cliente al trabajar con polimorfismo, no se ve afectado.
*/

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
