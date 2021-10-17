using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion.App.Dominio;

namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioAdministrador
    {
        
        Administrador AddAdministrador(Administrador administrador);
        Administrador UpdateAdministrador(Administrador administrador);
        void DeleteAdministradorxId(int id); 
        void DeleteAdministrador(int identAdministrador); 
        Administrador GetAdministrador(Administrador administrador);
       // Administrador  GetAdministrador(int identAdministrador,int passAdministrador);  
    }
}