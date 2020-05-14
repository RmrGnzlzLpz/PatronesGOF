using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interfaces
{
    public interface IAbstractFactory
    {
        IButton CrearButton(string accion);
        IScrollbar CrearScrollbar();
        ITextField CrearTextfield();
    }
}
