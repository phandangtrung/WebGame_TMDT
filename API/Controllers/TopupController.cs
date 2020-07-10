using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace API.Controllers{
    [ApiController]
    [Route("api/[Controller]")]
    public class TopupController: Controller{
        private readonly AppDbContext _db;
        public TopupController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<IEnumerable<TopupHistory>>> GetHistoryTopupOfUser(string id)
        {
            var topups = await _db.TopupHistories.Where(u => u.ApplicationUserID == id).ToListAsync();
            if(topups == null)
            {
                return NotFound();
            }
            return Ok(topups);
        }
    }
}