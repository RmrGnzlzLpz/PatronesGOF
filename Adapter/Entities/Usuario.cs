using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Disponible { get; set; }
        public Usuario(int id, string nombre, double disponible)
        {
            Id = id;
            Nombre = nombre;
            Disponible = disponible;
        }
    }
}
