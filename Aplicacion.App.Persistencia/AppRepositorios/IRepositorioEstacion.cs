using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;

namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioEstacion
    {
        IEnumerable<Estacion> GetAllEstaciones();
        Estacion AddEstacion(Estacion estacion);
        Estacion UpdateEstacion(Estacion estacion);
        void DeleteEstacionxId(int id); 
        void DeleteEstacion(string codigoEstacion);    
        Estacion GetEstacion(string codigoEstacion);
        TecnicoMantenimiento AsignarTecnico(string codigoEstacion, TecnicoMantenimiento tecnico); 

        
    } 
}