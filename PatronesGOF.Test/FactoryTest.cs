using Factory.Entities;
using Factory.Factory;
using Factory.Interfaces;
using NUnit.Framework;

namespace Factory.Test
{
    /*
 * Descripcion del problema:
 * Queremos que en nuestro videojuego se generen enemigos de diferentes maneras.
 * Algunos jugadores quieren que los enemigos generados sean mas dificiles, otros quieren que se generen de modo normal.
 * Para ello construimos factorías que nos permiten generar enemigos de diferentes formas, incluso podríamos generar
 * más factorías para generar solo Ninjas, o solo Samurais; y el cliente al trabajar con polimorfismo, no se ve afectado.
*/

    public class FactoryTests
    {
        IEnemigoFactory Factory { get; set; }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CrearRandom()
        {
            Factory = new RandomEnemigoFactory();
            var enemy = Factory.CrearEnemigo();

            Assert.IsTrue(enemy is IEntity);
        }

        [Test]
        public void CrearNinja()
        {
            Factory = new NinjaEnemigoFactory(); // Podemos crear cuántas factories sean necesarias.
            var enemy = Factory.CrearEnemigo();

            Assert.IsTrue(enemy is Ninja);
            Assert.IsTrue(enemy is IEntity);
        }
    }
}