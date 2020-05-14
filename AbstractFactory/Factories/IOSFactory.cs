using AbstractFactory.Entities;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    public class IOSFactory : IAbstractFactory
    {
        public IButton CrearButton(string accion)
        {
            return new ButtonIOS { Accion = accion };
        }

        public IScrollbar CrearScrollbar()
        {
            return new ScrollbarIOS();
        }

        public ITextField CrearTextfield()
        {
            return new TextFieldIOS();
        }
    }
}
