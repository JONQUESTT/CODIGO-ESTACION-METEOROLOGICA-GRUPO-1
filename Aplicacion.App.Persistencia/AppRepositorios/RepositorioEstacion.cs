using System;
using System.Linq;
using Aplicacion.App.Dominio;
using System.Collections.Generic;
namespace Aplicacion.App.Persistencia
{
    public class RepositorioEstacion: IRepositorioEstacion
    {
        private readonly AppContext _appContext;
        public RepositorioEstacion(AppContext appContext)
        {
            _appContext=appContext;
        }

        
        Estacion IRepositorioEstacion.AddEstacion(Estacion estacion)
        {
            var estacionAdicionada=_appContext.Estaciones.Add(estacion);
            _appContext.SaveChanges();
            return estacionAdicionada.Entity;
        }

        Estacion IRepositorioEstacion.UpdateEstacion(Estacion estacion)
        {
            var estacionEncontrada=_appContext.Estaciones.FirstOrDefault(p=>  p.Codigo==estacion.Codigo);
            if(estacionEncontrada!=null)
            {
                estacionEncontrada.Codigo=estacion.Codigo;
                estacionEncontrada.Latitud=estacion.Latitud;
                estacionEncontrada.Longitud=estacion.Longitud;
                estacionEncontrada.Municipio=estacion.Municipio;
                estacionEncontrada.FechaMontaje=estacion.FechaMontaje;
                estacionEncontrada.Tecnico= estacion.Tecnico;
                _appContext.SaveChanges();
            }
            return estacionEncontrada;
        }

        Estacion IRepositorioEstacion.GetEstacion(string codigoEstacion)
        {
            var estacionEncontrada=_appContext.Estaciones.FirstOrDefault(p=> p.Codigo==codigoEstacion);
            return estacionEncontrada;
        }

        
        IEnumerable<Estacion> IRepositorioEstacion.GetAllEstaciones()
        {
            return _appContext.Estaciones;
        }

        
        void IRepositorioEstacion.DeleteEstacionxId(int id)
        {
            var estacionEncontrada=_appContext.Estaciones.FirstOrDefault(p=> p.Id==id);
            if(estacionEncontrada!=null)
            {
                _appContext.Estaciones.Remove(estacionEncontrada);
                _appContext.SaveChanges();
            }
            //return estacionEncontrada;
        }

        void IRepositorioEstacion.DeleteEstacion(string codigoEstacion) 
        {
            var estacionEncontrada=_appContext.Estaciones.FirstOrDefault(p=> p.Codigo==codigoEstacion);
            if(estacionEncontrada!=null)
            {
                _appContext.Estaciones.Remove(estacionEncontrada);
                _appContext.SaveChanges();
            }
            
        }

        TecnicoMantenimiento IRepositorioEstacion.AsignarTecnico(string codigoEstacion, TecnicoMantenimiento tecnico)
        {
           var estacionEncontrada=_appContext.Estaciones.FirstOrDefault(p=> p.Codigo==codigoEstacion);
           if (estacionEncontrada != null)
            {
                estacionEncontrada.Tecnico=tecnico;
                _appContext.SaveChanges();
                return tecnico;
            }
            return null;

        }

    }
}