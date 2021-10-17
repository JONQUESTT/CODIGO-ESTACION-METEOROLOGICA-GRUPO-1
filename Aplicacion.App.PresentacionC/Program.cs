using System;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;

namespace Aplicacion.App.PresentacionC
{
    class Program
    {
        private static IRepositorioPersona _repoPersona= new RepositorioPersona(new Persistencia.AppContext());
        static void Main(string[] args)
        {

            Console.WriteLine("Inicio de pruebas");
            InsertarPersona();

        }

        //Se crea aca solo para pruebas
        private static void InsertarPersona()
        {
            var p = new Persona
            {
                Nombres = "Carlos",
                Apellidos = "Guerra",
                Identificacion = 4567,
                //Genero = "Femenino",
                //Estado = 'A'
            };
            _repoPersona.AddPersona(p);
        }
    }
}
