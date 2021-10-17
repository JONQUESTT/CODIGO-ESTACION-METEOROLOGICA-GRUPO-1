using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion.App.Dominio;
namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioPersonalInstituto
    {
        PersonalInstituto AddPersonalInstituto(PersonalInstituto pInst);
        void DeletePersonalInstitutoxId(int id); 
        void DeletePersonalInstituto(int identificacionPersonalInst);    
        PersonalInstituto GetPersonalInstituto(int identificacionPersonalInst);
        

    }
}
  