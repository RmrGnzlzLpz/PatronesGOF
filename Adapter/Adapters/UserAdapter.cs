using Adapter.Entities;
using Adapter.Interfaces;
using Adapter.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapters
{
    public class UserAdapter : IUserAdapter
    {
        private ServicioBanco servicio = new ServicioBanco();
        public Usuario GetUsuario(int numeroCuenta)
        {
            RespuestaBanco respuesta = servicio.FindByNumeroCuenta(numeroCuenta);
            Usuario usuario = new Usuario(respuesta.Cuenta, respuesta.Nombre, respuesta.Balance);
            return usuario;
        }
    }
}
