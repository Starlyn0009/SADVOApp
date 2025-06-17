using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using SADVO.Infraestructure.Persistence.Contexts;

namespace SADVOApp.Infraestructure.Persistence.Contexts
{
    public class SADVOAppContextFactory : IDesignTimeDbContextFactory<SADVOAppContext>
    {
        public SADVOAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SADVOAppContext>();

            
            var connectionString = "Server=DESKTOP-609PVE9;Database=SADVO;Trusted_Connection=True;TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(connectionString,
                sql => sql.MigrationsAssembly(typeof(SADVOAppContext).Assembly.FullName));

            return new SADVOAppContext(optionsBuilder.Options);
        }
    }
}
