using Builder.Builders;
using Builder.Entities;
using NUnit.Framework;
using System.Collections.Generic;

namespace Builder.Test
{
    /*
 * Descripcion del problema:
 * Nuestro sistema trabaja con un objeto complejo, que iremos construyendo poco a poco, de manera que no
 * creamos un new Objeto hasta tener todos los par√°metros necesarios listos.
*/

    public class BuilderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test(Description = "Crear Cuenta Bancaria")]
        public void ConstruirCuenta()
        {
            string numero = "1111";
            Cliente cliente = new Cliente
            {
                PrimerNombre = "Ramiro", SegundoNombre = "Enrique", PrimerApellido = "Gonzalez", SegundoApellido = "Lopez"
            };
            // Construimos el builder, e incluimos 2 par·metros que usaremos para construir la cuenta.
            CuentaBancariaBuilder builder = new CuentaBancariaBuilder(numero).AsignarCliente(cliente);
            
            TipoCuenta tipo = TipoCuenta.Ahorro;
            double balance = 0.0;
            // Obtenemos 2 nuevos par·metros y los guardamos en el Builder.
            builder = builder.AsignarTipo(tipo).AsignarBalance(balance);

            double tasa = 10;
            builder = builder.AsignarInteres(tasa);
            // Luego de tener todos los par·metros, construimos la Cuenta.
            CuentaBancaria cuenta = builder.Build();

            // Testeamos todos los parametros enviados, de manera que correspondan a las propiedades del objeto construido.
            Assert.AreEqual(cuenta.Numero, numero);
            Assert.AreEqual(cuenta.Cliente, cliente);
            Assert.AreEqual(cuenta.Tipo, tipo);
            Assert.AreEqual(cuenta.Balance, balance);
            Assert.AreEqual(cuenta.TasaInteres, tasa);
        }
    }
}
