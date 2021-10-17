using System;

namespace Aplicacion.App.Dominio
{
    public class Persona
    {
        public int Id{get;set;}
        public int Identificacion{get;set;}
        public string Nombres{get;set;}
        public string Apellidos{get;set;}
        public string Genero{get;set;}
        public char Estado{get;set;}// a:Activo, i:Inactivo, l:Lead        
    }
}