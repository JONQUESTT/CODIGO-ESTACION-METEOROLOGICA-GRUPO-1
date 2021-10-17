using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion.App.Dominio;
namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioValidacion
    {
        
        Validacion AddValidacion(Validacion validacion);
        Validacion UpdateValidacion(int id,int val);
        Validacion GetValidacion(int id);
        
        
    }
}