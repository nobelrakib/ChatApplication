
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context=context;
        }

        [HttpGet]
        [AllowAnonymous]

        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users =await _context.Users.ToListAsync();
            return users;
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task< ActionResult<AppUser>> Get(int id)
        {
            var user =await _context.Users.FindAsync(id);
            return user;
        }
    }
}