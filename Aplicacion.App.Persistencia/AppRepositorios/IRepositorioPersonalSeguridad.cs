using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion.App.Dominio;
namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioPersonalSeguridad
    {
        IEnumerable<PersonalSeguridad> GetAllPSeguridad();
        PersonalSeguridad AddPersonalSeguridad(PersonalSeguridad pSeg);
        PersonalSeguridad UpdatePersonalSeguridad(PersonalSeguridad pSeg);
        void DeletePersonalSeguridadxId(int id); 
        void DeletePersonalSeguridad(int identificacionPersonalSeg);    
        PersonalSeguridad GetPersonalSeguridad(int identificacionPersonalSeg);
    }
}
  