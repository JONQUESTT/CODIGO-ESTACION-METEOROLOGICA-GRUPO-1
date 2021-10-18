using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aplicacion.App.Persistencia;
using Aplicacion.App.Dominio;

namespace FrontEnd.Pages
{
    public class InicioReporteModel : PageModel
    {
        [BindProperty]
        public Estacion estacion {get;set;}
        [BindProperty]
        public TecnicoMantenimiento tecnico{get;set;}
        [TempData]
        public int identec{get;set;} 
        [TempData]
        public string codigoestacion{get;set;}
        public static IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioTecnicoMantenimiento _repoTecnico = new RepositorioTecnicoMantenimiento(new Aplicacion.App.Persistencia.AppContext());
    
        public void OnGet()
        {
            codigoestacion="";
        }
        public void OnPost()
        {

        }
        public IActionResult OnPostConsultarEstacion()
        {   
           string url="";
           estacion=_repoEstacion.GetEstacion(estacion.Codigo);
           if(estacion!=null)
           {
               codigoestacion=estacion.Codigo;
               url="AddDatMet";
           }
           else
           {
                codigoestacion="";
                url="";
           }
           return RedirectToPage(url);
        }
        public IActionResult OnPostConsultarTecnico()
        {   
           string url="";
           tecnico = _repoTecnico.GetTecnicoMantenimiento(tecnico.Identificacion);
           if(tecnico!=null)
           {
               identec=tecnico.Identificacion;
               url="ReporteTecnico";
           }
           else
           {
                identec=0;
                url="";
           }
           return RedirectToPage(url);
        }
    }
}
