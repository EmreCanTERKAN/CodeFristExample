using DENEMEMEMEMEMEMEMWEMEME.Data;
using DENEMEMEMEMEMEMEMWEMEME.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DENEMEMEMEMEMEMEMWEMEME.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MyDbContext _myDbContext;

        public MoviesController(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetAllMovies()
        {
            return await _myDbContext.Movies.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovieByID (int id)
        {
            var movie = await _myDbContext.Movies.FirstOrDefaultAsync(x => x.ID == id);
            if (movie is null)
            {
                return NotFound();
            }
            return movie;
        }
    }
}
