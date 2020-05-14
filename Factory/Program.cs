using Factory.Abstract;
using Factory.Entities;
using Factory.Factory;
using Factory.Interfaces;
using System;

/*
 * Descripcion del problema:
 *      
*/

namespace Factory
{
    class Program
    {
        public static readonly Random random = new Random();
        public static bool PuedeGenerarEnemigos { get; set; }

        static void Main(string[] args)
        {
            PuedeGenerarEnemigos = true;
            IEnemigoFactory factory = new DificilEnemigoFactory();

            for (int i = 0; i < 100; i++)
            {
                Logica(factory);
            }
            Console.ReadKey();
        }

        static void Logica(IEnemigoFactory factory)
        {
            // Logica adicional
            if (PuedeGenerarEnemigos)
            {
                IEntity enemigo = factory.CrearEnemigo();
                enemigo.Actualizar();
            }
            // Mas logica aqui
        }
    }
}
