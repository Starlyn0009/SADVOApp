using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SADVO.Infraestructure.Persistence.Contexts;

namespace SADVO.Infraestructure.Persistence
{
    public static class ServicesRegistration
    {
        // Metodo para registrar el contexto de la base de datos y configuraciones relacionadas
        public static void AddPersistenceLayerIoc(this IServiceCollection services, IConfiguration config)
        {

            #region Cotexts
            if(config.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<SADVOAppContext>(opt =>
                    opt.UseInMemoryDatabase("SADVOInMemoryDb"));
            }
            else
            {
                var connectionString = config.GetConnectionString("DefaultConnection");
                services.AddDbContext<SADVOAppContext>(opt =>
                    opt.UseSqlServer(connectionString,
                    m => m.MigrationsAssembly(typeof(SADVOAppContext).Assembly.FullName))
                    , ServiceLifetime.Transient);                   
            }
            #endregion
        }
    }
}
