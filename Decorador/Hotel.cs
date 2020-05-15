using System;

namespace Decorador
{
    public class Hotel : IHospedaje
    {
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public double Costo { get; set; }

        public Hotel(string descripcion)
        {
            Descripcion = descripcion;
            Costo = 100000;
            Tipo = "Hotel";
        }
    }
}
