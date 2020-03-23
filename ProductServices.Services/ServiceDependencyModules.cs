namespace ProductServices.Services
{
    using Microsoft.Extensions.DependencyInjection;
    using ProductServices.Services.Users;
    using ProductServices.Services.Users.Interfaces;

    public class ServiceDependencyModules
    {
        public static void ServiceDependencies(IServiceCollection services)
        {
            services.AddTransient<IUsersService, UsersService>();
        }
    }
}
