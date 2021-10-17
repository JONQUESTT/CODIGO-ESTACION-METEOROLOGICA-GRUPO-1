using System;

namespace Aplicacion.App.Dominio
{
    public class TecnicoMantenimiento:Persona
    {
        public int TarjetaProfesional{get;set;}
        public Reporte Reporte{get;set;}
    }
}