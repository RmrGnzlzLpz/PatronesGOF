using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Interfaces
{
    public interface IEntity
    {
        int Nivel { get; set; }
        int Vida { get; set; }
        int Energia { get; set; }
        void SubirNivel();
        void Actualizar();
    }
}
