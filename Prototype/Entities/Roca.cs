using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Entities
{
    public class Roca : IClonable<Roca>
    {
        public int Radio { get; set; }
        public Roca ClonarProfundo()
        {
            return ClonarSuperficial();
        }

        public Roca ClonarSuperficial()
        {
            return new Roca
            {
                Radio = Radio
            };
        }
    }
}
