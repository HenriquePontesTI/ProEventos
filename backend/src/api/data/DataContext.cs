using Microsoft.EntityFrameworkCore;
using api.models;

namespace api.data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Evento> Eventos { get; set; }
  }
}