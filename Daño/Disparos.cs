using System;
using Personajes;
using Interfaces;

namespace Daño
{
    public class Disparos : Interarmas
    {
        public bool disparar(personajes personajes)
        {
            Console.WriteLine("El personaje {0} ha recojido un arma {1}", personajes.Nombre, personajes.Arma);
            return true;
        }
    }
}
