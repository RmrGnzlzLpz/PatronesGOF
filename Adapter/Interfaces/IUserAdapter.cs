using Adapter.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Interfaces
{
    public interface IUserAdapter
    {
        Usuario GetUsuario(int numeroCuenta);
    }
}
