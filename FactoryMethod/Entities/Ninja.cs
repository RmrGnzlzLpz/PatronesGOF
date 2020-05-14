using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Entities
{
    public class Ninja : Enemigo
    {
        public Ninja()
        {
            Vida = 100;
            Energia = 200;
            Velocidad = 180;
            Fuerza = 50;
        }
        public override void Actualizar()
        {
            base.Actualizar();
            Console.WriteLine($"Actualizando Ninja. Vida: {Vida}. Energia{Energia}.");
        }

        public override void Atacar()
        {
            base.Atacar();
            Console.WriteLine($"Ninja Atacando. Fuerza: {Fuerza}.");
        }

        public override void Caminar()
        {
            base.Caminar();
            Console.WriteLine($"Ninja Caminando. Velocidad: {Velocidad}.");
        }

        public override void Correr()
        {
            base.Correr();
            Console.WriteLine($"Que Ninja tan veloz. Velocidad: {Velocidad}");
        }
    }
}
