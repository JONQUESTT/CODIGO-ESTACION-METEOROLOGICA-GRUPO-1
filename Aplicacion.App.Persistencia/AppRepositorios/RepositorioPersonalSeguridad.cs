using System;
using System.Linq;
using Aplicacion.App.Dominio;
using Aplicacion.App.Persistencia;
using System.Collections.Generic;
namespace Aplicacion.App.Persistencia
{
    public class RepositorioPersonalSeguridad :IRepositorioPersonalSeguridad
    {
        private readonly AppContext _appContext;
        public RepositorioPersonalSeguridad(AppContext appContext)
        {
            _appContext=appContext;
        }

        PersonalSeguridad IRepositorioPersonalSeguridad.AddPersonalSeguridad(PersonalSeguridad pSeg)
        {
            var PSeguridadAdicionado=_appContext.PerSeg.Add(pSeg);
            _appContext.SaveChanges();
            return PSeguridadAdicionado.Entity;
        }

        PersonalSeguridad IRepositorioPersonalSeguridad.UpdatePersonalSeguridad(PersonalSeguridad pSeg)
        {
            var PSeguridadEncontrado=_appContext.PerSeg.FirstOrDefault(p=>  p.Identificacion==pSeg.Identificacion);
            if(PSeguridadEncontrado!=null)
            {
                PSeguridadEncontrado.Nombres=pSeg.Nombres;
                PSeguridadEncontrado.Apellidos=pSeg.Apellidos;
                PSeguridadEncontrado.Estado=pSeg.Estado;
                PSeguridadEncontrado.Genero=pSeg.Genero;
                 _appContext.SaveChanges();
            }
            return PSeguridadEncontrado;
        }


        PersonalSeguridad  IRepositorioPersonalSeguridad.GetPersonalSeguridad(int identificacionPersonalSeg)
        {
            var PSeguridadEncontrado=_appContext.PerSeg.FirstOrDefault(p=>  p.Identificacion==identificacionPersonalSeg);
            return PSeguridadEncontrado;
        }

        
        IEnumerable<PersonalSeguridad> IRepositorioPersonalSeguridad.GetAllPSeguridad()
        {
            return _appContext.PerSeg;
        }

        void IRepositorioPersonalSeguridad.DeletePersonalSeguridadxId(int id)
        {
            var PSeguridadEncontrado=_appContext.PerSeg.FirstOrDefault(p=>  p.Id==id);
            if(PSeguridadEncontrado!=null)
            {
                _appContext.PerSeg.Remove(PSeguridadEncontrado);
                _appContext.SaveChanges();
            }
            //return estacionEncontrada;
        }

        void IRepositorioPersonalSeguridad.DeletePersonalSeguridad(int identificacionPersonalSeg)
        {
            var PSeguridadEncontrado=_appContext.PerSeg.FirstOrDefault(p=>  p.Identificacion==identificacionPersonalSeg);
            if(PSeguridadEncontrado!=null)
            {
                _appContext.PerSeg.Remove(PSeguridadEncontrado);
                _appContext.SaveChanges();
            }
        }
    }
}