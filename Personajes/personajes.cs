using System;

namespace Personajes
{
    public class personajes
    {
        public string Nombre { get; set; }
        public string Arma { get; set; }
        public personajes(string nombre, string arma)
        {
            Nombre = nombre;
            Arma = arma;
        }
    }
}
