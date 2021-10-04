using System;
using System.Collections.Generic;

namespace Aplicacion.App.Dominio
{
    public class Reporte
    {
        public int Id{get;set;}
        public string Descripcion{get;set;}
        //En este caso se accede de forma directa a datos de lista por lo cual se usa list
        //public List<TipoReporte> TiposReporte{get;set;}
    }
}