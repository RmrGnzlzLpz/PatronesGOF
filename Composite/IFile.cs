using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public interface IFile
    {
        string Nombre { get; set; }
        string Ls();
    }
}
