using DENEMEMEMEMEMEMEMWEMEME.Data;
using DENEMEMEMEMEMEMEMWEMEME.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DENEMEMEMEMEMEMEMWEMEME.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly MyDbContext _myDbContext;

        public GamesController(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetAllGames()
        {
            return await _myDbContext.Games.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGameId (int id)
        {
            var game = await _myDbContext.Games.FindAsync(id);
            if (game is null)
            {
                return NotFound();
            }
            return game;
        }
        
    }
}
