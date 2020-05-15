using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Entities
{
    public class Terreno : IClonable<Terreno>
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public Terreno Clonar()
        {
            return new Terreno
            {
                Largo = this.Largo,
                Ancho = this.Ancho
            };
        }
    }
}
