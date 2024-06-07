
using ApiUsuariosUeceMy.Domain.Interfaces;
using ApiUsuariosUeceMy.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AppChurch.Ioc.Dependences
{
    public static class DepedencyInjection
    {
        public static void AddDepencies(this IServiceCollection services)
        {
            AddRepositoryDependency(services);
        }

        private static void AddRepositoryDependency(IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
