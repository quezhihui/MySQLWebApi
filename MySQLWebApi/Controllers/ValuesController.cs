using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySQLWebApi.Data;
using Microsoft.EntityFrameworkCore;
using MySQLWebApi.Models;

namespace MySQLWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        private UserContext _userContext;

        public ValuesController(UserContext userContext)
        {
            _userContext = userContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _userContext.Users.SingleOrDefaultAsync(x => x.Id == id));
        }
    }
}
