using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public abstract class Decorador : IHospedaje
    {
        public IHospedaje Hospedaje;
        public string Descripcion { get => Hospedaje.Descripcion; set => Hospedaje.Descripcion = value; }
        public string Tipo { get => Hospedaje.Tipo; set => Hospedaje.Tipo = value; }
        public double Costo { get => Hospedaje.Costo; set => Hospedaje.Costo = value; }

        public Decorador(IHospedaje hospedaje)
        {
            Hospedaje = hospedaje;
        }
    }
}
