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
    public class CountriesController : Controller
    {
        private readonly AppDbContext _db;
        public CountriesController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> GetAllCountry()
        {
            return await _db.Countries.ToListAsync();
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Country>> GetCountryById(int id)
        {
            var country = await _db.Countries.Where(u => u.ID == id).FirstOrDefaultAsync();
            if (country != null)
            {
                return Ok(country);
            }
            return NotFound();
        }
        [HttpGet]
        [Route("studios/{id}")]
        public async Task<ActionResult<IEnumerable<Studio>>> GetStudioOfCountry(int id)
        {
            var studios = await _db.Studios.Where(u => u.ID == id).ToListAsync();
            if (studios != null)
            {
                return Ok(studios);
            }
            return NotFound();
        }
        [HttpGet]
        [Route("games/{id}")]
        public async Task<ActionResult<IEnumerable<Game>>> GetGameOfCountry(int id)
        {
            var games = await _db.Games.Where(u => u.Studio.CountryID == id).Include(u => u.Studio).ToListAsync();
            if (games != null)
            {
                return Ok(games);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult<Country>> CreateCountry(Country country)
        {
            _db.Countries.Add(country);
            await _db.SaveChangesAsync();
            return CreatedAtAction("GetCountryById", new { id = country.ID }, country);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Country>> UpdateCountry(int id, Country country)
        {
            if (id != country.ID)
            {
                return BadRequest();
            }
            var getCountry = await _db.Countries.Where(u => u.ID == id).FirstOrDefaultAsync();
            getCountry.Countryname = country.Countryname;
            getCountry.Alias = country.Alias;
            try
            {
                _db.Update(getCountry);
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
            return country;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Country>> DeleteCountry(int id)
        {
            var country = await _db.Countries.FindAsync(id);
            if(country == null)
            {
                return NotFound();
            }
            _db.Remove(country);
            await _db.SaveChangesAsync();
            return country;
        }
        private bool NewExists(int id)
        {
            return _db.Countries.Any(e => e.ID == id);
        }
    }
}
