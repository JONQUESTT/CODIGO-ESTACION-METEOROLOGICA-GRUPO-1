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
    public class AddDatMetModel : PageModel
    {
        [BindProperty]
        public Estacion estacion {get;set;}
        [BindProperty]
        public TecnicoMantenimiento tecnico{get;set;}
        [BindProperty]
        public DatoMeteorologico dato {get;set;}
        [TempData]
        public string codigoestacion{get;set;}
        [TempData]
        public string mensajeerror{get;set;}
        public static IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new Aplicacion.App.Persistencia.AppContext());
        public static IRepositorioTecnicoMantenimiento _repoTecnico=new RepositorioTecnicoMantenimiento(new Aplicacion.App.Persistencia.AppContext());
        //public static IRepositorioDato _repoDato=new RepositorioDato(new MonitoreoMeteorologico.App.Persistencia.AppContext());
    
        public void OnGet()
        {
            estacion=_repoEstacion.GetEstacion(codigoestacion);
            mensajeerror = "";
        }
        public void OnPost()
        {

        }
        public void OnPostAsigTec()
        {
            estacion = _repoEstacion.GetEstacion(estacion.Codigo);
            if (estacion != null)
            {
                tecnico = _repoTecnico.GetTecnicoMantenimiento(tecnico.Identificacion);
                if (tecnico != null)
                {
                    _repoEstacion.AsignarTecnico(estacion.Codigo, tecnico);
                    mensajeerror = "Operacion Exitosa";
                }
                else{
                    mensajeerror = "Técnico no existe";
                }
            }
            else{
                mensajeerror = "Estación no existe";
            }
        }
    }
}
