using Microsoft.EntityFrameworkCore;
using API_movies_jueves_jd.DAL.Models;


namespace API_movies_jueves_jd.DAL
{
    public class ApplicationsDbContext : DbContext
    {
        public ApplicationsDbContext(DbContextOptions<ApplicationsDbContext> options) : base(options)
        {
            
        }

        //Seccion para crear el dbset de las entidades o MODELOS
        public DbSet<Category> Categories { get; set; }

    }
}
