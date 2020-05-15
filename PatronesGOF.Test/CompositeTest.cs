using Composite;
using NUnit.Framework;
using System.Collections.Generic;

namespace Adapter.Test
{
    /*
 * Descripcion del problema:
 * Manejamos un sistema gestor de archivos, el cual contiene directorios que contienen otros directorios o archivos.
 * Se usa el patrón composite, generando un tipo de árbol de n niveles.
*/

    public class CompositeTests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void CrearDirectorio()
        {
            Directorio myMusic = new Directorio("Mi Musica");
            Directorio myVideo = new Directorio("Mis Vídeos");
            Directorio myDownload = new Directorio("Mis Descargas");

            Directorio myUser = new Directorio("Mi Usuario");

            Archivo myMp3 = new Archivo("Hola Mundo.mp3");
            Archivo myMp4 = new Archivo("Como programar.mp4");
            Archivo myExe = new Archivo("Virus.exe");

            myMusic.Add(myMp3);
            myVideo.Add(myMp4);
            myDownload.Add(myExe);

            myUser.Add(myMusic);
            myUser.Add(myVideo);
            myUser.Add(myDownload);

            string respuesta = myUser.Ls();

            Assert.IsTrue(respuesta.Contains(myMp4.Ls()));
            Assert.IsTrue(respuesta.Contains(myMusic.Ls()));
        }
    }
}