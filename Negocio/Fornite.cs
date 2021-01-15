using System;
using Personajes;
using Interfaces;

namespace Negocio
{
    public class Fornite
    {
        Interarmas Arma;
        public Fornite(Interarmas Arma)
        {
            this.Arma = Arma;
        }
        public void AccionDisparar(personajes personajes)
        {
            Arma.disparar(personajes);
        }
    }
}
