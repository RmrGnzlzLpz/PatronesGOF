using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Entities
{
    public class Samurai : Enemigo
    {
        public Samurai()
        {
            Vida = 150;
            Energia = 200;
            Velocidad = 50;
            Fuerza = 180;
        }
        public override void Actualizar()
        {
            base.Actualizar();
            Console.WriteLine($"Actualizando Samurai. Vida: {Vida}. Energia{Energia}.");
        }

        public override void Atacar()
        {
            base.Atacar();
            Console.WriteLine($"Samurai Atacando. Fuerza: {Fuerza}.");
        }

        public override void Caminar()
        {
            base.Caminar();
            Console.WriteLine($"Samurai Caminando. Velocidad: {Velocidad}.");
        }

        public override void Correr()
        {
            base.Correr();
            Console.WriteLine($"Que Samurai tan veloz. Velocidad: {Velocidad}");
        }
    }
}
