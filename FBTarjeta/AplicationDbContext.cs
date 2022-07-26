using FBTarjeta.Models;
using Microsoft.EntityFrameworkCore;

namespace FBTarjeta
{
    public class AplicationDbContext : DbContext //Crea una instancia en la base de datos para poder almacenarlos 
    {

        //public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        //{

        //}

        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<TarjetaCredito> TarjetaCredito { get; set; }//Se mapea el modelo con la base de datos
    }
}
