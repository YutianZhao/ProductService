namespace ProductServices.Services.Users
{
    using ProductService.Repositories.Repositories.Users.Interfaces;
    using ProductServices.Services.Users.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ProductService.Models;

    public class UsersService: IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<IEnumerable<Users>> GetUsersByIdAsync(int? userId)
        {
            return await this._usersRepository.GetUsersByIdAsync(userId);
        }
    }
}
