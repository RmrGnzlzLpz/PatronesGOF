using NUnit.Framework;
using Singleton.Entities;

namespace Factory.Test
{
    /*
 * Descripcion del problema:
 * Nuestro sistema requiere una conexi�n a la base de datos, pero dicha conexi�n debe ser �nica en la ejecuci�n del programa, con el fin de evitar conflictos.
*/

    public class SingletonTests
    {
        Conexion conexion;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Conectar()
        {
            conexion = Conexion.GetConexion();

            Assert.IsNotNull(conexion);
        }

        [Test]
        public void DobleInstancia()
        {
            conexion = Conexion.GetConexion();
            var conexion2 = Conexion.GetConexion();

            Assert.AreEqual(conexion, conexion2);
        }

        [Test]
        public void ModificarInstancia()
        {
            conexion = Conexion.GetConexion();
            var conexion2 = Conexion.GetConexion();

            conexion.Engine = "MySql";
            conexion2.Engine = "OracleDB";
            // Los dos objetos hacen referencia a la misma instancia, por lo tanto un cambio de un objeto afecta al otro objeto.
            Assert.AreEqual(conexion.Engine, "OracleDB");
        }
    }
}