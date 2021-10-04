using System;

namespace Aplicacion.App.Dominio
{
    public class Estacion
    {
        public int Id{get;set;}
        public string Codigo{get;set;}
        public float Latitud{get;set;}
        public float Longitud{get;set;}
        public string Municipio{get;set;}
        public DateTime FechaMontaje{get;set;}
        public Reporte Reporte{get;set;}
        public TecnicoMantenimiento Tecnico{get;set;}
        //En la siguiente linea no accede a datos de la lista de forma directa sino a los datos que llama la clase de datos meterologicos, por eso se usa system.collections 
        public System.Collections.Generic.List<DatoMeteorologico> DatoMeteorologico{get;set;}  
    }
}