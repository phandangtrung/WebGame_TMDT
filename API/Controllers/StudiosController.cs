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
    public class StudiosController : Controller
    {
        private readonly AppDbContext _db;
        public StudiosController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Studio>>> GetAll()
        {
            return await _db.Studios.Include(u => u.Country).ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Studio>> GetStudioById(int id)
        {
            var studio = await _db.Studios.Where(u => u.ID == id).Include(u => u.Country).FirstOrDefaultAsync();
            if(studio == null)
            {
                return NotFound();
            }
            return Ok(studio);
        }
        [HttpGet("games/{id}")]
        public async Task<ActionResult<List<Game>>> GetGamesOfStudio(int id)
        {
            var games = await _db.Games.Where(u => u.StudioID == id).Include(u => u.Studio).Include(u => u.SystemRequirement).ToListAsync();
            return games;
        }
        [HttpPost]
        public async Task<ActionResult<Studio>> CreateStudio(Studio studio)
        {
            _db.Studios.Add(studio);
            await _db.SaveChangesAsync();
            return CreatedAtAction("GetStudioById",new {id = studio.ID},studio);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Studio>> UpdateStudio(int id, Studio studio)
        {
            var getStudio = await _db.Studios.FindAsync(id);
            if(getStudio == null)
            {
                return NotFound();
            }
            getStudio = studio;
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
                throw;
            }
            return getStudio;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Studio>> DeleteStudio(int id)
        {
            var studio = await _db.Studios.FindAsync(id);
            if(studio == null)
            {
                return NotFound();
            }
            _db.Studios.Remove(studio);
            await _db.SaveChangesAsync();
            return studio;
        }
    }
}
