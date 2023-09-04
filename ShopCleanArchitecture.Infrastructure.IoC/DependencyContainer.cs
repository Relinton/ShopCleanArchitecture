using Microsoft.Extensions.DependencyInjection;
using ShopCleanArchitecture.Application.Interfaces;
using ShopCleanArchitecture.Application.Services;
using ShopCleanArchitecture.Domain.Interfaces;
using ShopCleanArchitecture.Infra.Data.Repositories;

namespace ShopCleanArchitecture.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IProdutoService, ProdutoService>();

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}
