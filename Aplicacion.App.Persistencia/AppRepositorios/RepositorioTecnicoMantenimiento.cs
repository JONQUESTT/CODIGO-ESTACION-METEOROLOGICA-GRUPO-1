using System;
using System.Linq;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;
using System.Collections.Generic;
namespace Aplicacion.App.Persistencia
{
    public class RepositorioTecnicoMantenimiento :IRepositorioTecnicoMantenimiento
    {
        private readonly AppContext _appContext;
        public RepositorioTecnicoMantenimiento(AppContext appContext)
        {
            _appContext=appContext;
        }

        TecnicoMantenimiento IRepositorioTecnicoMantenimiento.AddTecnicoMantenimiento(TecnicoMantenimiento tecnicoMantenimiento)
        {
            var tecnicoAdicionado=_appContext.Tecnicos.Add(tecnicoMantenimiento);
            _appContext.SaveChanges();
            return tecnicoAdicionado.Entity;
        }

        TecnicoMantenimiento IRepositorioTecnicoMantenimiento.UpdateTecnicoMantenimiento(TecnicoMantenimiento tecnicoMantenimiento)
        {
            var tecnicoEncontrado=_appContext.Tecnicos.FirstOrDefault(p=>  p.Identificacion==tecnicoMantenimiento.Identificacion);
            if(tecnicoEncontrado!=null)
            {
                tecnicoEncontrado.Nombres=tecnicoMantenimiento.Nombres;
                tecnicoEncontrado.Apellidos=tecnicoMantenimiento.Apellidos;
                tecnicoEncontrado.Estado=tecnicoMantenimiento.Estado;
                tecnicoEncontrado.TarjetaProfesional=tecnicoMantenimiento.TarjetaProfesional;
                 _appContext.SaveChanges();
            }
            return tecnicoEncontrado;
        }


        TecnicoMantenimiento  IRepositorioTecnicoMantenimiento.GetTecnicoMantenimiento(int identTecnicoMantenimiento)
        {
            var tecnicoEncontrado=_appContext.Tecnicos.FirstOrDefault(p=>  p.Identificacion==identTecnicoMantenimiento);
            return tecnicoEncontrado;
        }

        
        IEnumerable<TecnicoMantenimiento> IRepositorioTecnicoMantenimiento.GetAllTecnicos()
        {
            return _appContext.Tecnicos;
        }

        void IRepositorioTecnicoMantenimiento.DeleteTecnicoMantenimientoxId(int id)
        {
            var tecnicoEncontrado=_appContext.Tecnicos.FirstOrDefault(p=>  p.Id==id);
            if(tecnicoEncontrado!=null)
            {
                _appContext.Tecnicos.Remove(tecnicoEncontrado);
                _appContext.SaveChanges();
            }
            //return estacionEncontrada;
        }

        void IRepositorioTecnicoMantenimiento.DeleteTecnicoMantenimiento(int identTecnicoMantenimiento)
        {
            var tecnicoEncontrado=_appContext.Tecnicos.FirstOrDefault(p=>  p.Identificacion==identTecnicoMantenimiento);
            if(tecnicoEncontrado!=null)
            {
                _appContext.Tecnicos.Remove(tecnicoEncontrado);
                _appContext.SaveChanges();
            }
            
        }
       /*  Reporte IRepositorioTecnicoMantenimiento.AsignarReporte(int identec,Reporte reporte)
        {
            var tecnicoEncontrado=_appContext.Tecnicos.FirstOrDefault(p=>  p.Identificacion==identec);
            if(tecnicoEncontrado!=null)
            {
                tecnicoEncontrado.Reporte=reporte;
                _appContext.SaveChanges();
            }

        } */
 
        
    }
}