using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Interfaces
{
    public interface IEnemigo
    {
        int Vida { get; set; }
        int Energia { get; set; }
        int Fuerza { get; set; }
        int Velocidad { get; set; }
        void Atacar();
        void Caminar();
        void Correr();
        void Saltar();
        void Actualizar();
    }
}
