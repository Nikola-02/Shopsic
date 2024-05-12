using Microsoft.EntityFrameworkCore;
using Shopsic.Domain;

namespace Shopsic.DataAccess
{
    public class ShopsicContext : DbContext
    {
        private readonly string _connectionString;
        public ShopsicContext()
        {
            this._connectionString = "Data Source=DESKTOP-RJ8270A\\SQLEXPRESS;Initial Catalog=Shopsic;TrustServerCertificate=true;Integrated security = true";
        }

        public ShopsicContext(string _connectionString)
        {
            this._connectionString = _connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }

        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }

    }
}
