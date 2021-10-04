using Microsoft.EntityFrameworkCore;
using Aplicacion.App.Dominio;

namespace Aplicacion.App.Persistencia
{
 public class AppContext:DbContext
 {
     //Con la siguiente linea se crea una tabla en BD con los datos de persona
     public DbSet<Dominio.Persona> Personas{get;set;}
     public DbSet<Dominio.Estacion> Estaciones{get;set;}
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
         if (!optionsBuilder.IsConfigured)
         {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aplicacion1DB");
         }
     }
 }   
}