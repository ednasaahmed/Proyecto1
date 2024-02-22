using Microsoft.EntityFrameworkCore;
using Proyecto1.Models;

namespace Proyecto1.Context
{
    public class EdContext:DbContext
    {
        public EdContext(DbContextOptions<EdContext> contextOptions) :base(contextOptions) 
        { 
        }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Libros> Libros { get; set; }
    }
}
