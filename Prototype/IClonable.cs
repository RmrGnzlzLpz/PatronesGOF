using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public interface IClonable<T>
    {
        T Clonar();
    }
}
