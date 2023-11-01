using librerias_PMRI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace librerias_PMRI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }  
}
