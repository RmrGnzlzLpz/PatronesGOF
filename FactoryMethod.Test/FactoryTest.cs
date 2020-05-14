using Factory.Entities;
using Factory.Factory;
using Factory.Interfaces;
using NUnit.Framework;

namespace Factory.Test
{
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
            Factory = new NinjaEnemigoFactory();
            var enemy = Factory.CrearEnemigo();

            Assert.IsTrue(enemy is Ninja);
            Assert.IsTrue(enemy is IEntity);
        }
    }
}