using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class GamesController : Controller
    {
        private readonly AppDbContext _db;
        public GamesController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetAll()
        {
            return await _db.Games.Include(u => u.Studio).ToListAsync();
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Game>> GetById(int id)
        {
            return await _db.Games.Where(u => u.ID == id).Include(u => u.Studio).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("search")]
        public async Task<ActionResult<IEnumerable<Game>>> SearchGame(string q)
        {
            var games = await _db.Games.Where(u => u.Gamename.Trim().ToLower().Contains(q.Trim().ToLower()) || u.Studio.Studioname.Trim().ToLower().Contains(q.Trim().ToLower())).Include(u => u.Studio).ToListAsync();
            if (games == null)
            {
                return NotFound();
            }
            return Ok(games);
        }
        [HttpPost]
        public async Task<ActionResult<Game>> CreateGame([FromBody] Game game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Not a valid model");
            }
            _db.Add(game);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (System.Exception)
            {

                throw;
            }

            return CreatedAtAction("GetById", new { id = game.ID }, game);
        }
        //[HttpPost]
        //public async Task<ActionResult<Comment>> UserComment(int gameid, string userid)
        //{

        //}
        [HttpPatch("publish/{id}")]
        public async Task<ActionResult<Game>> PublishGame(int id)
        {
            var game = await _db.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            if (game.IsPublish)
            {
                game.IsPublish = false;
            }
            else
            {
                game.IsPublish = true;
            }
            await _db.SaveChangesAsync();
            return game;
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Game>> UpdateGame(int id, Game game)
        {
            if (id != game.ID)
            {
                return BadRequest();
            }
            var getGame = await _db.Games.FindAsync(id);
            getGame = game;
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return getGame;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Game>> DeleteGame(int id)
        {
            var game = await _db.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            _db.Games.Remove(game);
            await _db.SaveChangesAsync();
            return game;
        }
        private bool NewExists(int id)
        {
            return _db.Games.Any(u => u.ID == id);
        }
    }
}
