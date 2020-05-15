using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Entities
{
    public class RespuestaBanco
    {
        public int Cuenta { get; set; }
        public string Nombre { get; set; }
        public double Balance { get; set; }
        public RespuestaBanco(int cuenta, string nombre, double balance)
        {
            Cuenta = cuenta;
            Nombre = nombre;
            Balance = balance;
        }
    }
}
