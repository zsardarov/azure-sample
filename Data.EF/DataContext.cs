using Data.EF.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
 
namespace Data.EF
{
    public class DataContext : DbContext
    {
/*        private readonly string _connectionString;
*/
        public DataContext(DbContextOptions options) : base(options)
        {

        }

   /*     public DataContext(string connectionString)
        {
            _connectionString = connectionString;
        }*/

        public DbSet<Person> People { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString, b =>
            {
                b.MigrationsAssembly("AzData.EF");
            });
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
