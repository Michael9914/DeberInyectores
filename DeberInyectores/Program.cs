using System;
using Interfaces;
using Personajes;
using Negocio;
using Daño;
using Ninject;

namespace DeberInyectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a mi juego!");
            var eleccionUsuario = 0;
            var kernel = new StandardKernel();

            Console.WriteLine("Elige tu skin favorita");
            Console.WriteLine("1) Deal Pool");
            Console.WriteLine("2) Aquaman");
            Console.WriteLine("3) Travis Scott");
            Console.WriteLine("4) Kratos");
            Console.WriteLine("5) Galaxy");
            Console.WriteLine("6) Thor");
            eleccionUsuario = int.Parse(Console.ReadLine());

            if(eleccionUsuario == 1)
            {
                personajes personajes1 = new personajes("Deal Pool", "Fusil de asalto");
                kernel.Bind<Interarmas>().To<Disparos>();
                var personaje1 = kernel.Get<Fornite>();
                personaje1.AccionDisparar(personajes1);
            }

            if (eleccionUsuario == 2)
            {
                personajes personajes2 = new personajes("Aquaman", "Subfusil");
                kernel.Bind<Interarmas>().To<Disparos>();
                var personaje2 = kernel.Get<Fornite>();
                personaje2.AccionDisparar(personajes2);
            }

            if (eleccionUsuario == 3)
            {
                personajes personajes3 = new personajes("Travis Scott", "Pico");
                kernel.Bind<Interarmas>().To<Disparos>();
                var personaje3 = kernel.Get<Fornite>();
                personaje3.AccionDisparar(personajes3);
            }

            if (eleccionUsuario == 4)
            {
                personajes personajes4 = new personajes("Kratos", "Espadas del Exilio");
                kernel.Bind<Interarmas>().To<Disparos>();
                var personaje4 = kernel.Get<Fornite>();
                personaje4.AccionDisparar(personajes4);
            }

            if (eleccionUsuario == 5)
            {
                personajes personajes5 = new personajes("Galaxy", "Rifle de francotirador");
                kernel.Bind<Interarmas>().To<Disparos>();
                var personaje5 = kernel.Get<Fornite>();
                personaje5.AccionDisparar(personajes5);
            }

            if (eleccionUsuario == 6)
            {
                personajes personajes6 = new personajes("Thor", "Martillo de Thor");
                kernel.Bind<Interarmas>().To<Disparos>();
                var personaje6 = kernel.Get<Fornite>();
                personaje6.AccionDisparar(personajes6);
            }
        }
    }            
}
