using NUnit.Framework;
using System.Collections.Generic;

namespace Decorador.Test
{
    /*
 * Descripcion del problema:
 * Se requiere gestionar el hospedaje de los clientes en un hotel.
 * El precio varia dependiendo las peticiones y condiciones del cliente.
 * Se usarán decoradores para agregarle nuevas características al hospedaje.
*/

    public class DecoradorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CrearHotel()
        {
            IHospedaje hotelCartagena = new Hotel("Hotel en Cartagena"); // 100000
            hotelCartagena = new VistaAlMar(hotelCartagena); // +100000

            Assert.AreEqual(200000, hotelCartagena.Costo);

            hotelCartagena = new DescuentoVIP(hotelCartagena);
            Assert.AreEqual("Hotel en Cartagena (Vista Al Mar) (Descuento VIP)", hotelCartagena.Descripcion);
        }
    }
}
