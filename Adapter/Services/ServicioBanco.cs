using Adapter.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Services
{
    public class ServicioBanco
    {
        // Este es un servicio externo
        public RespuestaBanco FindByNumeroCuenta(int numeroCuenta)
        {
            switch (numeroCuenta)
            {
                case 1:
                    return new RespuestaBanco(numeroCuenta, "Ramiro", 1000000);
                case 2:
                    return new RespuestaBanco(numeroCuenta, "Daniela", 2000000);
                case 3:
                    return new RespuestaBanco(numeroCuenta, "Paola", 3000000);
                default:
                    return null;
            }
        }
    }
}
