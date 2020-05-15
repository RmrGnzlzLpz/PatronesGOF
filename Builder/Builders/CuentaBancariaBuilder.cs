using Builder.Entities;
using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builders
{
    public class CuentaBancariaBuilder : IBuilder<CuentaBancaria>
    {
        public string NumeroCuenta { get; set; }
        public Cliente Cliente { get; set; }
        public TipoCuenta TipoCuenta { get; set; }
        public double Balance { get; set; }
        public double TasaInteres { get; set; }

        public CuentaBancariaBuilder(string numeroCuenta)
        {
            NumeroCuenta = numeroCuenta;
        }
        public CuentaBancariaBuilder AsignarCliente(Cliente cliente)
        {
            Cliente = cliente;
            return this;
        }
        public CuentaBancariaBuilder AsignarTipo(TipoCuenta tipo)
        {
            TipoCuenta = tipo;
            return this;
        }
        public CuentaBancariaBuilder AsignarBalance(double balance)
        {
            Balance = balance;
            return this;
        }
        public CuentaBancariaBuilder AsignarInteres(double interes)
        {
            TasaInteres = interes;
            return this;
        }

        public CuentaBancaria Build()
        {
            CuentaBancaria cuentaBancaria = new CuentaBancaria
            {
                Numero = NumeroCuenta,
                Cliente = Cliente,
                Tipo = TipoCuenta,
                Balance = Balance,
                TasaInteres = TasaInteres
            };
            return cuentaBancaria;
        }
    }
}
