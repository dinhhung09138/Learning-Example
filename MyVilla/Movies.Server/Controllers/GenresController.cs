using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Movies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    public class GenresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public GenresController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Genre genre)
        {
            _context.Add(genre);
            _context.SaveChanges();
            return Ok(genre.Id);
        }
    }
}
