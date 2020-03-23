namespace ProductService.Repositories.Repositories.Users
{
    using Dapper;
    using Microsoft.Extensions.Configuration;
    using ProductService.Repositories.Repositories.Users.Interfaces;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Threading.Tasks;

    public class UsersRepository : IUsersRepository
    {
        private readonly IConfiguration _config;
        public UsersRepository(IConfiguration config)
        {
            _config = config;
        }
        private IDbConnection dbConnection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("MyConnectionString"));
            }
        }
        public async Task<IEnumerable<Models.Users>> GetUsersByIdAsync (int? userId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@userId", userId);
            using (IDbConnection dbconnection = dbConnection)
            {
                dbConnection.Open();
                var result = await dbconnection.QueryAsync<Models.Users>("usp_GetUsersById", parameters, commandType: CommandType.StoredProcedure);
                return result.AsList();
            }
        }
    }
}
