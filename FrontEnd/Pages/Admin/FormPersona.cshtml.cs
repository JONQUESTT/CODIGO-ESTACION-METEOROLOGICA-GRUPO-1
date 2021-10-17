using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;

namespace MyApp.Namespace
{
    
    public class FormPersonaModel : PageModel
    {
       public static IRepositorioPersona _repoPersona=new RepositorioPersona(new Aplicacion.App.Persistencia.AppContext());
        public void OnGet()
        {
        }
        public void OnPost(int Identificacion,string Nombre,string Apellido,string Genero,char EstadoPersona)
        {
            var persona=new Persona();
            persona.Nombres=Nombre;
            persona.Identificacion=Identificacion;
            persona.Apellidos=Apellido;
            persona.Genero=Genero;
            persona.Estado=EstadoPersona;
            _repoPersona.AddPersona(persona);
        }
    }


    
}
