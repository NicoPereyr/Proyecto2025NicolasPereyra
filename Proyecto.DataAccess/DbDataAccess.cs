using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proyecto.Entities;

namespace Proyecto.DataAccess
{
    public class DbDataAccess : IdentityDbContext
    {
        public virtual DbSet<Marca> Brands { get; set; }
        public virtual DbSet<Categoria> Categories { get; set; }
        public virtual DbSet<Deposito> Deposits { get; set; }
        public virtual DbSet<Producto> Products { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public DbDataAccess(DbContextOptions<DbDataAccess> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.LogTo(Console.WriteLine).EnableDetailedErrors();
    }

}
