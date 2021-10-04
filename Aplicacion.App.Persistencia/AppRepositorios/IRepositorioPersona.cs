using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;

namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();
        Persona AddPersona(Persona persona);    
        Persona UpDatePersona(Persona persona);    
        Persona GetPersona(string Identificacion);    
        Persona DeletePersona(string Identificacion);    
        
    } 
}