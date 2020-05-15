using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Entities
{
    public class Conexion
    {
        public string Engine { get; set; } = "PostgreSQL";
        public string User { get; set; } = "localhost";
        public string Password { get; set; } = "123456";
        public string Database { get; set; } = "postgres";
        public bool Connected { get; private set; } = false;

        private static Conexion instancia;

        //Evitamos el operador «new»
        private Conexion() { }

        //Solo podremos obtener la instancia por este método
        public static Conexion GetConexion()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }

        public void Conectar()
        {
            if (Connected)
            {
                throw new Exception("Error, conexión en proceso");
            }
            Connected = true;
        }

        public void Desconectar()
        {
            if (!Connected)
            {
                throw new Exception("Error, conexión inválida");
            }
            Connected = false;
        }

        public override string ToString()
        {
            return $"Engine = {Engine}; User = {User}; Password = {Password}; Database = {Database}";
        }
    }
}
