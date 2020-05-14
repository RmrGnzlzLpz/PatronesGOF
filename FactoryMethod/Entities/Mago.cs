using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Entities
{
    public class Mago : Enemigo
    {
        public Mago()
        {
            Vida = 150;
            Energia = 200;
            Velocidad = 150;
            Fuerza = 50;
        }
        public override void Actualizar()
        {
            base.Actualizar();
            Console.WriteLine($"Actualizando Mago. Vida: {Vida}. Energia{Energia}.");
        }

        public override void Atacar()
        {
            base.Atacar();
            Console.WriteLine($"Mago Atacando. Fuerza: {Fuerza}.");
        }

        public override void Caminar()
        {
            base.Caminar();
            Console.WriteLine($"Mago Caminando. Velocidad: {Velocidad}.");
        }

        public override void Correr()
        {
            base.Correr();
            Console.WriteLine($"Que Mago tan veloz. Velocidad: {Velocidad}");
        }
    }
}
