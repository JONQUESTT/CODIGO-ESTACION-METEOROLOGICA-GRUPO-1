using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;

namespace FrontEnd.Pages
{
     public class AddAdminModel : PageModel
    {
        [BindProperty]
        public Estacion estacion {get;set;}
        [BindProperty]
        public TecnicoMantenimiento tecnico{get;set;}

        public static IRepositorioValidacion _repoValidacion=new RepositorioValidacion(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioTecnicoMantenimiento _repoTecnico=new RepositorioTecnicoMantenimiento(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
    
        public IActionResult OnGet()
        {
            if(_repoValidacion.GetValidacion(1).Val!=1)
            {
                return RedirectToPage("InicioAdmin");
            }
            else
            {   
                _repoValidacion.UpdateValidacion(1,0);
                return Page(); 
            }   
        }
        public void OnPost()
        {   
        }
        public void OnPostCrearEstacion()
        {   
            _repoEstacion.AddEstacion(estacion);
        }
        public void OnPostCrearTecnico()
        {   
            _repoTecnico.AddTecnicoMantenimiento(tecnico);
        }
    }
}
