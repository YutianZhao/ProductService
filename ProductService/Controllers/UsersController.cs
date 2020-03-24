using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductService.Models;
using ProductService.Repositories.Repositories.Users.Interfaces;
using ProductServices.Services.Users.Interfaces;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        // .../api/users/1
        // Ok method will return a Json file. So no need Json serializer for now.
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsersById(int? id)
        {
            return Ok(await this._usersService.GetUsersByIdAsync(id));
        }
    }
}
