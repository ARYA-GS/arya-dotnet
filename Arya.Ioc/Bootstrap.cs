using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Arya.Application;
using Arya.Application.Services;
using Arya.Application.Services.Interfaces;
using Arya.Infraestructure.Data.AppData;
using Arya.Infraestructure.Data.Repositories;
using Arya.Infraestructure.Data.Repositories.Interfaces;
using Arya.Infraestructure.Mappings;

namespace Arya.Ioc;

public class Bootstrap
{
    public static void Start(IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<ApplicationContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("Oracle");
            options.UseOracle(connectionString);
        });

        service.AddScoped<IUserRepository, UserRepository>();
        service.AddScoped<IUserService, UserService>();

        service.AddScoped<IClimaticEventRepository, ClimaticEventRepository>();
        service.AddScoped<IClimaticEventService, ClimaticEventService>();

        service.AddScoped<ISafeResourceRepository, SafeResourceRepository>();
        service.AddScoped<ISafeResourceService, SafeResourceService>();

        service.AddScoped<ISentimentAnalysisService, SentimentAnalysisService>();

        service.AddAutoMapper(typeof(MapperProfile));
    }
}
