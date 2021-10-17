using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion.App.Dominio;
namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioTecnicoMantenimiento
    {
        IEnumerable<TecnicoMantenimiento> GetAllTecnicos();
        TecnicoMantenimiento AddTecnicoMantenimiento(TecnicoMantenimiento tecnicoMantenimiento);
        TecnicoMantenimiento UpdateTecnicoMantenimiento(TecnicoMantenimiento tecnicoMantenimiento);
        void DeleteTecnicoMantenimientoxId(int id); 
        void DeleteTecnicoMantenimiento(int identTecnicoMantenimiento);    
        TecnicoMantenimiento GetTecnicoMantenimiento(int identTecnicoMantenimiento);
       // Reporte AsignarReporte(int identec,Reporte reporte);
    }
}