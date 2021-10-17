using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;
namespace Aplicacion.App.Persistencia
{
    public class RepositorioReporte:IRepositorioReporte
    {
        
       
        private readonly AppContext _appContext;
        public RepositorioReporte(AppContext appContext)
        {
            _appContext=appContext;
        }

        Reporte IRepositorioReporte.AddReporte(Reporte reporte)
        {
            var reporteAdicionado=_appContext.Reportes.Add(reporte);
            _appContext.SaveChanges();
            return reporteAdicionado.Entity;

        }
        Reporte IRepositorioReporte.GetReporte(int id)
        {
            var reporteEncontrado=_appContext.Reportes.FirstOrDefault(p=>  p.Id==id);
            return reporteEncontrado;
        }
    }
}