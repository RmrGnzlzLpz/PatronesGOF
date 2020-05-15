using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Entities
{
    public class CuentaBancaria
    {
        public string Numero { get; set; }
        public Cliente Cliente { get; set; }
        public TipoCuenta Tipo { get; set; }
        public double Balance { get; set; }
        public double TasaInteres { get; set; }

        public override string ToString()
        {
            return $"Numero = {Numero}; Cliente = {Cliente.NombreCompleto}; Tipo = {Tipo}; Balance = {Balance}; TasaInteres = {TasaInteres}";
        }
    }

    public enum TipoCuenta
    {
        Ahorro = 0, Corriente = 1
    }
}
