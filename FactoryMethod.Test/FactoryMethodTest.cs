using NUnit.Framework;
using FactoryMethod.Interfaces;
using FactoryMethod.Factories;
using FactoryMethod.Entities;

namespace FactoryMethod.Test
{
    public class FactoryMethodTests
    {
        IEnemigoFactory Factory;

        [SetUp]
        public void Setup()
        {
            Factory = new EnemigoFactory();
        }

        [Test]
        public void CrearNinja()
        {
            IEnemigo enemigo = Factory.CrearEnemigo(TipoEnemigo.Ninja);
            enemigo.Actualizar();
            enemigo.Caminar();

            Assert.IsTrue(enemigo is Ninja);
        }

        [Test]
        public void CrearSamurai()
        {
            IEnemigo enemigo = Factory.CrearEnemigo(TipoEnemigo.Samurai);
            enemigo.Atacar();
            enemigo.Saltar();

            Assert.IsTrue(enemigo is Samurai);
        }

        [Test]
        public void CrearMago()
        {
            IEnemigo enemigo = Factory.CrearEnemigo(TipoEnemigo.Mago);
            enemigo.Atacar();
            enemigo.Saltar();

            Assert.IsTrue(enemigo is Mago);
        }
    }
}