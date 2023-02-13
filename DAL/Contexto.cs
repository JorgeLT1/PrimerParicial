using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Libro> libro { get; set; }

    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }
}