using Bridge.Entities;
using Bridge.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace Adapter.Test
{
    /*
 * Descripcion del problema:
 * Necesitamos dibujar varias figuras con diferentes t�cnicas.
 * Implementamos una interfaz puente que nos permitir� dibujar con diferentes t�cnicas sin necesidad de crear una clase por cada tipo de figura combinada con cada tipo de t�cnica.
 * As� separamos la implementaci�n de la abstracci�n.
*/

    public class BridgeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test(Description = "Dibujamos c�rculos de las dos formas posibles [punteada, normal]")]
        public void DibujarCirculo()
        {
            IDibujo metodoDibujo1 = new DibujoPunteado();
            Circulo circulo1 = new Circulo(metodoDibujo1, 2, 3, 3);

            Assert.AreEqual("Dibujando C�rculo Punteado", circulo1.Dibujar());

            IDibujo metodoDibujo2 = new DibujoNormal();
            Circulo circulo2 = new Circulo(metodoDibujo2, 3, 2, 4);

            Assert.AreEqual("Dibujando C�rculo Normal", circulo2.Dibujar());
        }

        [Test(Description = "Dibujamos rect�ngulos de las dos formas posibles [punteada, normal]")]
        public void DibujarRectangulo()
        {
            IDibujo metodoDibujo1 = new DibujoPunteado();
            Rectangulo rectangulo1 = new Rectangulo(metodoDibujo1, 2, 3, 3, 4);

            Assert.AreEqual("Dibujando Rect�ngulo Punteado", rectangulo1.Dibujar());

            IDibujo metodoDibujo2 = new DibujoNormal();
            Rectangulo rectangulo2 = new Rectangulo(metodoDibujo2, 3, 2, 6, 5);

            Assert.AreEqual("Dibujando Rect�ngulo Normal", rectangulo2.Dibujar());
        }
    }
}