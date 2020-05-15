using AbstractFactory.Interfaces;
using AbstractFactory.Factories;
using NUnit.Framework;
using AbstractFactory.Entities;

namespace AbstractFactory.Test
{
    /*
* Descripcion del problema:
* Un framework multiplataforma necesita gestionar los elementos de la pantalla para que sean acorde 
* a la plataforma a ejecutarse.
*/
    public class AbstractFactoryTests
    {
        IAbstractFactory factory;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CrearWeb()
        {
            factory = new WebFactory();

            IButton button = factory.CrearButton("Iniciar Sesion");
            IScrollbar scrollbar = factory.CrearScrollbar();
            ITextField textField = factory.CrearTextfield();

            Assert.IsTrue(button is ButtonWeb);
            Assert.IsTrue(scrollbar is ScrollbarWeb);
            Assert.IsTrue(textField is TextFieldWeb);

            Assert.AreEqual($"JavaScript: Ejecutando Iniciar Sesion.", button.Presionar());
            Assert.AreEqual($"JavaScript: Bajando", scrollbar.Bajar());

            char letra = 'a';
            Assert.AreEqual($"JavaScript: Input <{letra}>", textField.Escribir(letra));
        }

        [Test]
        public void CrearAndroid()
        {
            factory = new AndroidFactory();

            IButton button = factory.CrearButton("Registrarse");
            IScrollbar scrollbar = factory.CrearScrollbar();
            ITextField textField = factory.CrearTextfield();

            Assert.IsTrue(button is ButtonAndroid);
            Assert.IsTrue(scrollbar is ScrollbarAndroid);
            Assert.IsTrue(textField is TextFieldAndroid);

            Assert.AreEqual($"Android: Ejecutando Registrarse.", button.Presionar());
            Assert.AreEqual($"Android: Bajando", scrollbar.Bajar());

            char letra = 'x';
            Assert.AreEqual($"Android: Input <{letra}>", textField.Escribir(letra));
        }

        [Test]
        public void CrearIOS()
        {
            factory = new IOSFactory();

            IButton button = factory.CrearButton("Enviar");
            IScrollbar scrollbar = factory.CrearScrollbar();
            ITextField textField = factory.CrearTextfield();

            Assert.IsTrue(button is ButtonIOS);
            Assert.IsTrue(scrollbar is ScrollbarIOS);
            Assert.IsTrue(textField is TextFieldIOS);

            Assert.AreEqual($"IOS: Ejecutando Enviar.", button.Presionar());
            Assert.AreEqual($"IOS: Bajando", scrollbar.Bajar());

            char letra = 'm';
            Assert.AreEqual($"IOS: Input <{letra}>", textField.Escribir(letra));
        }
    }
}