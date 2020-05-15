using Bridge.Entities;
using Bridge.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace Adapter.Test
{
    /*
 * Descripcion del problema:
 * Necesitamos dibujar varias figuras con diferentes técnicas.
 * Implementamos una interfaz puente que nos permitirá dibujar con diferentes técnicas sin necesidad de crear una clase por cada tipo de figura combinada con cada tipo de técnica.
 * Así separamos la implementación de la abstracción.
*/

    public class BridgeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test(Description = "Dibujamos círculos de las dos formas posibles [punteada, normal]")]
        public void DibujarCirculo()
        {
            IDibujo metodoDibujo1 = new DibujoPunteado();
            Circulo circulo1 = new Circulo(metodoDibujo1, 2, 3, 3);

            Assert.AreEqual("Dibujando Círculo Punteado", circulo1.Dibujar());

            IDibujo metodoDibujo2 = new DibujoNormal();
            Circulo circulo2 = new Circulo(metodoDibujo2, 3, 2, 4);

            Assert.AreEqual("Dibujando Círculo Normal", circulo2.Dibujar());
        }

        [Test(Description = "Dibujamos rectángulos de las dos formas posibles [punteada, normal]")]
        public void DibujarRectangulo()
        {
            IDibujo metodoDibujo1 = new DibujoPunteado();
            Rectangulo rectangulo1 = new Rectangulo(metodoDibujo1, 2, 3, 3, 4);

            Assert.AreEqual("Dibujando Rectángulo Punteado", rectangulo1.Dibujar());

            IDibujo metodoDibujo2 = new DibujoNormal();
            Rectangulo rectangulo2 = new Rectangulo(metodoDibujo2, 3, 2, 6, 5);

            Assert.AreEqual("Dibujando Rectángulo Normal", rectangulo2.Dibujar());
        }
    }
}