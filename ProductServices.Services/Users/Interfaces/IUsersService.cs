namespace ProductServices.Services.Users.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ProductService.Models;

    public interface IUsersService
    {
        Task<IEnumerable<Users>> GetUsersByIdAsync(int? userId);
    }
}
