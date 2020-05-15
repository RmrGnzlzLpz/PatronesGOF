using Builder.Builders;
using Builder.Entities;
using NUnit.Framework;
using System.Collections.Generic;

namespace Builder.Test
{
    /*
 * Descripcion del problema:
 * Nuestro sistema trabaja con un objeto complejo, que iremos construyendo poco a poco, de manera que no
 * creamos un new Objeto hasta tener todos los parámetros necesarios listos.
*/

    public class BuilderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test(Description = "Crear Cuenta Bancaria")]
        public void ModificarSuperficial()
        {
            string numero = "1111";
            Cliente cliente = new Cliente
            {
                PrimerNombre = "Ramiro", SegundoNombre = "Enrique", PrimerApellido = "Gonzalez", SegundoApellido = "Lopez"
            };
            CuentaBancariaBuilder builder = new CuentaBancariaBuilder(numero).AsignarCliente(cliente);
            
            TipoCuenta tipo = TipoCuenta.Ahorro;
            double balance = 0.0;
            builder = builder.AsignarTipo(tipo).AsignarBalance(balance);

            double tasa = 10;
            builder = builder.AsignarInteres(tasa);

            CuentaBancaria cuenta = builder.Build();

            Assert.AreEqual(cuenta.Numero, numero);
            Assert.AreEqual(cuenta.Cliente, cliente);
            Assert.AreEqual(cuenta.Tipo, tipo);
            Assert.AreEqual(cuenta.Balance, balance);
            Assert.AreEqual(cuenta.TasaInteres, tasa);
        }
    }
}