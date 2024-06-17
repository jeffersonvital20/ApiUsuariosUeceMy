
using ApiUsuariosUeceMy.Domain.Interfaces;
using ApiUsuariosUeceMy.Infra.Repositories;
using ApiUsuariosUeceMy.Services;
using ApiUsuariosUeceMy.Services.Interface;

namespace ApiUsuariosUeceMy.Infra.Dependences
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
            services.AddScoped<IRabbitServices, RabbitServices>();
        }
    }
}
