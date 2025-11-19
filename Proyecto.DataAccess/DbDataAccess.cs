using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proyecto.Entities;
using Proyecto.Entities.MicrosoftIdentity;

namespace Proyecto.DataAccess
{
    public class DbDataAccess : IdentityDbContext<User, Role, Guid, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public DbDataAccess(DbContextOptions<DbDataAccess> options) : base(options) { }
        public DbDataAccess()
        {

        }
        public virtual DbSet<Marca> Brands { get; set; }
        public virtual DbSet<Categoria> Categories { get; set; }
        public virtual DbSet<Deposito> Deposits { get; set; }
        public virtual DbSet<Producto> Products { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.LogTo(Console.WriteLine).EnableDetailedErrors();
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}


