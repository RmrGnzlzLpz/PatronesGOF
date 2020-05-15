using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Entities
{
    public class Terreno : IClonable<Terreno>
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public TipoSuelo TipoSuelo { get; set; }
        public List<Arbol> Arboles { get; set; }
        public List<Roca> Rocas { get; set; }
        public Camara Camara { get; set; }

        public Terreno ClonarProfundo()
        {
            return new Terreno
            {
                Largo = Largo,
                Ancho = Ancho,
                TipoSuelo = TipoSuelo,
                Arboles = Arboles.Select(x => x.ClonarProfundo()).ToList(),
                Rocas = Rocas.Select(x => x.ClonarProfundo()).ToList(),
                Camara = Camara.ClonarProfundo()
            };
        }

        public Terreno ClonarSuperficial()
        {
            return new Terreno
            {
                Largo = Largo,
                Ancho = Ancho,
                TipoSuelo = TipoSuelo,
                Arboles = Arboles,
                Rocas = Rocas,
                Camara = Camara
            };
        }
    }

    public enum TipoSuelo
    {
        Lodo = 0, Rocoso = 1, Arena = 2, 
    }
}
