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
    [Route("api/codes")]
    public class CodesController : Controller
    {
        private readonly AppDbContext _db;
        public CodesController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Code>>> GetAll()
        {
            return await _db.Codes.ToListAsync();
        }
        [HttpGet]
        [Route("game/{id}")]
        public async Task<ActionResult<Code>> GetCodeOfGame(int id)
        {
            var code = await _db.Codes.Where(u => u.GameID == id && u.Available == true).FirstOrDefaultAsync();
            if(code != null)
            {
                return Ok(code);
            }
            return NotFound();
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Code>> GetCodeById(int id)
        {
            return await _db.Codes.Where(u => u.ID == id).FirstOrDefaultAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Code>> CreateCode(Code code){
            _db.Codes.Add(code);
            await _db.SaveChangesAsync();
            return code;
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Code>> UpdateCode(int id, Code code)
        {
            var getCode = await _db.Codes.FindAsync(id);
            if(getCode == null)
            {
                return NotFound();
            }
            getCode = code;
            await _db.SaveChangesAsync();
            return code;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCode(int id)
        {
            var code = await _db.Codes.Where(u => u.ID == id).FirstOrDefaultAsync();
            _db.Codes.Remove(code);
            await _db.SaveChangesAsync();
            return Ok();
        }
    }
}
