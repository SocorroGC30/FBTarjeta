using Microsoft.EntityFrameworkCore;

namespace FBTarjeta
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
             
        }



    }
}
