using Microsoft.EntityFrameworkCore;
using WebApi2025.DAL.Entities;

namespace WebApi2025.DAL
{
    public class DataBaseContext: DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }

        //Comment 2
        #region DbSets
        public DbSet<Country> countries { get; set; }

        #endregion



    }
}
