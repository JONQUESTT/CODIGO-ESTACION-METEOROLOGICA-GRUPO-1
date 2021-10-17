using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion.App.Dominio;
namespace Aplicacion.App.Persistencia
{
    public interface IRepositorioReporte
    {
        Reporte  AddReporte(Reporte reporte);
        Reporte GetReporte(int id);
    }
}