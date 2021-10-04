using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;

namespace Aplicacion.App.Persistencia
{
    public class RepositorioPersona: IRepositorioPersona
    {
        private readonly AppContext _appContext;
        //Constructor
        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }
        //Implementacion metodos de la interface
        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionada = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionada.Entity;
        }
        Persona IRepositorioPersona.UpDatePersona(Persona persona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p=> p.Identificacion == persona.Identificacion);
            if (personaEncontrada != null)
            {
                personaEncontrada.Identificacion = persona.Identificacion;
                personaEncontrada.Nombres = persona.Nombres;
                personaEncontrada.Apellidos = persona.Apellidos;
                personaEncontrada.Genero = persona.Genero;
                personaEncontrada.Estado = persona.Estado;
                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }
        Persona IRepositorioPersona.GetPersona(string Identificacion)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p=> p.Identificacion == Identificacion);
            return personaEncontrada;
        }
        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.Personas;
        }
        Persona IRepositorioPersona.DeletePersona(string Identificacion)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p=> p.Identificacion == Identificacion);
            if (personaEncontrada != null)
            {
                _appContext.Personas.Remove(personaEncontrada);
                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }
    }
}