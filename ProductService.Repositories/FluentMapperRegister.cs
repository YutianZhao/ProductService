namespace ProductService.Repositories
{
    using Dapper.FluentMap;
    using ProductService.Repositories.Users;

    public class FluentMapperRegister
    {
        public static void FluentMapperMapping()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new UsersEntityMap());
            });

        }
    }
}
