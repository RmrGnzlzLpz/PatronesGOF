using AbstractFactory.Entities;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    public class WebFactory : IAbstractFactory
    {
        public IButton CrearButton(string accion)
        {
            return new ButtonWeb { Accion = accion };
        }

        public IScrollbar CrearScrollbar()
        {
            return new ScrollbarWeb();
        }

        public ITextField CrearTextfield()
        {
            return new TextFieldWeb();
        }
    }
}
