namespace ProductService.Repositories.Repositories.Users.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IUsersRepository
    {
        Task<IEnumerable<Models.Users>> GetUsersByIdAsync (int? userId);
    }
}
