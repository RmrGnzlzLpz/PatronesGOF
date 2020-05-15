using Builder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Interfaces
{
    public interface IBuilder<T>
    {
        T Build();
    }
}
