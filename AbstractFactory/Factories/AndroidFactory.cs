using AbstractFactory.Entities;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    public class AndroidFactory : IAbstractFactory
    {
        public IButton CrearButton(string accion)
        {
            return new ButtonAndroid { Accion = accion };
        }

        public IScrollbar CrearScrollbar()
        {
            return new ScrollbarAndroid();
        }

        public ITextField CrearTextfield()
        {
            return new TextFieldAndroid();
        }
    }
}
