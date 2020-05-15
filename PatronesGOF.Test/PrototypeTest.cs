using NUnit.Framework;
using Prototype.Entities;
using System.Collections.Generic;

namespace Prototype.Test
{
    /*
 * Descripcion del problema:
 * En nuestro videojuego, tenemos terrenos predeterminados, que el jugador podrá editar para crear
 * mundos personalizados. Para esto usaremos la clonación profunda.
*/

    public class PrototypeTests
    {
        Terreno predeterminado1;
        Terreno predeterminado2;

        [SetUp]
        public void Setup()
        {
            #region Terreno1
            List<Arbol> Arboles1 = new List<Arbol>();
            Arboles1.Add(new Arbol
            {
                Grosor = 20,
                Tipo = TipoArbol.Bajo
            });
            Arboles1.Add(new Arbol
            {
                Grosor = 30,
                Tipo = TipoArbol.Alto
            });
            Arboles1.Add(new Arbol
            {
                Grosor = 50,
                Tipo = TipoArbol.Mediano
            });
            #endregion

            #region Terreno2
            List<Arbol> Arboles2 = new List<Arbol>();
            Arboles2.Add(new Arbol
            {
                Grosor = 30,
                Tipo = TipoArbol.Mediano
            });
            Arboles2.Add(new Arbol
            {
                Grosor = 80,
                Tipo = TipoArbol.Alto
            });
            Arboles2.Add(new Arbol
            {
                Grosor = 35,
                Tipo = TipoArbol.Mediano
            });
            #endregion

            predeterminado1 = new Terreno
            {
                Ancho = 1000,
                Largo = 1000,
                TipoSuelo = TipoSuelo.Arena,
                Arboles = Arboles1,
                Rocas = new List<Roca>(),
                Camara = new Camara()
            };
            predeterminado2 = new Terreno
            {
                Ancho = 2500,
                Largo = 2000,
                TipoSuelo = TipoSuelo.Rocoso,
                Arboles = Arboles2,
                Rocas = new List<Roca>(),
                Camara = new Camara()
            };
        }

        [Test(Description = "Clonamos un objeto de manera superficial, no incluye a los hijos")]
        public void ClonarSuperficial()
        {
            var clon1 = predeterminado1.ClonarSuperficial();
            var x = new { 
                predeterminado1.Ancho,
                predeterminado1.Largo,
                predeterminado1.TipoSuelo,
                predeterminado1.Arboles,
                predeterminado1.Rocas,
                predeterminado1.Camara
            };
            var y = new {
                clon1.Ancho,
                clon1.Largo,
                clon1.TipoSuelo,
                clon1.Arboles,
                clon1.Rocas,
                clon1.Camara
            };
            Assert.AreEqual(x, y);
        }

        [Test(Description = "Modificamos el clon de un objeto, y afecta al original")]
        public void ModificarSuperficial()
        {
            var clon2 = predeterminado2.ClonarSuperficial();

            clon2.Arboles.Add(new Arbol
            {
                Grosor = 78,
                Tipo = TipoArbol.Bajo
            });
            // clon2.Aboles = new List<Arbol>(); //Esta línea no funciona de igual manera

            Assert.AreEqual(clon2.Arboles, predeterminado2.Arboles);
        }

        [Test(Description = "Clonamos un objeto de manera profunda, incluyendo sus hijos")]
        public void ClonarProfundo()
        {
            var clon1 = predeterminado1.ClonarProfundo();
            var x = new
            {
                predeterminado1.Ancho,
                predeterminado1.Largo,
                predeterminado1.TipoSuelo,
                predeterminado1.Arboles,
                predeterminado1.Rocas,
                predeterminado1.Camara
            };
            var y = new
            {
                clon1.Ancho,
                clon1.Largo,
                clon1.TipoSuelo,
                clon1.Arboles,
                clon1.Rocas,
                clon1.Camara
            };
            Assert.AreEqual(x, y);
        }

        [Test(Description = "Modificamos el clon, y el original no se ve afectado")]
        public void ModificarProfundo()
        {
            var clon1 = predeterminado1.ClonarProfundo();

            clon1.Arboles.Add(new Arbol
            {
                Grosor = 16,
                Tipo = TipoArbol.Alto
            });

            Assert.AreNotEqual(clon1.Arboles, predeterminado1.Arboles);
        }
    }
}