namespace ProductService.Repositories
{
    using Microsoft.Extensions.DependencyInjection;
    using ProductService.Repositories.Repositories.Users;
    using ProductService.Repositories.Repositories.Users.Interfaces;

    public class RepositoryDependencyModules
    {
        public static void RepositoryDependencies(IServiceCollection services)
        {
            services.AddTransient<IUsersRepository, UsersRepository>();
        }
    }
}
