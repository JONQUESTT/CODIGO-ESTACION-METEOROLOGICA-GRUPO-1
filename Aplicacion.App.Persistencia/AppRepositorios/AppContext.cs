using Microsoft.EntityFrameworkCore;
using Aplicacion.App.Dominio;

namespace Aplicacion.App.Persistencia
{
 public class AppContext:DbContext
 {
     //Con la siguiente linea se crea una tabla en BD con los datos de persona
     public DbSet<Persona> Personas { get; set; }
        public DbSet<Estacion> Estaciones { get; set; }
        public DbSet<TecnicoMantenimiento> Tecnicos { get; set; }
        public DbSet<PersonalInstituto> PersonalClima { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<DatoMeteorologico> DatosMeteorologicos { get; set; }
        public DbSet<Reporte> Reportes { get; set; }
        public DbSet<TipoReporte> TiposReporte { get; set; }
        public DbSet<Validacion> Validaciones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
         if (!optionsBuilder.IsConfigured)
         {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aplicacion1DB33");
         }
     }
 }   
}