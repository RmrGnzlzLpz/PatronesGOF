using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Builder.Entities
{
    public class Cliente
    {
        [Required] public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        [Required] public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NombreCompleto { 
            get {
                return $"{PrimerNombre} {SegundoNombre} {PrimerApellido} {SegundoApellido}";
            }
        }
    }
}
