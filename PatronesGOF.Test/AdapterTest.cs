using Adapter.Adapters;
using Adapter.Entities;
using Adapter.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace Adapter.Test
{
    /*
 * Descripcion del problema:
 * Consumimos un servicio de un banco sobre los datos de un usuario.
 * Pero la interfaz obtenida no es compatible con lo que el cliente desea.
 * Por lo tanto usamos un adaptador para que el cliente obtenga un usuario y no una response del banco.
*/

    public class AdapterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test(Description = "Obtenemos una respuesta de un servicio y lo adaptamos a lo que necesitamos")]
        public void AdaptarResponse()
        {
            IUserAdapter adapter = new UserAdapter();
            Usuario usuario = adapter.GetUsuario(1);

            Assert.AreEqual("Ramiro", usuario.Nombre);
        }
    }
}