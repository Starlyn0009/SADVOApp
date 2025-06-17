using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using SADVOApp.Core.Application.Interfaces;
using SADVOApp.Core.Application.Services;

namespace SADVOApp.Core.Application
{
    public static class ServiceRegistration
    {
        // Extention Method
       
        public static void AddApplicationLayerIoc(this IServiceCollection services)
        {
            #region Configuratios
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            #endregion

            #region Services Ioc
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<ICiudadanoService, CiudadanoService>();
            services.AddTransient<ICandidatoService, CandidatoService>();
            services.AddTransient<IPuestoElectivoService, PuestoElectivoService>();
            services.AddTransient<IPartidoPoliticoService, PartidoPoliticoService>();
            services.AddTransient<IAlianzaPoliticaService, AlianzaPoliticaService>();          
            #endregion
        }
    }
}
