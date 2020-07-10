﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public NewsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/News
        [HttpGet]
        public async Task<ActionResult<IEnumerable<New>>> GetNews()
        {
            return await _context.News.ToListAsync();
        }

        // GET: api/News/5
        [HttpGet("{id}")]
        public async Task<ActionResult<New>> GetNew(int id)
        {
            var @new = await _context.News.FindAsync(id);

            if (@new == null)
            {
                return NotFound();
            }

            return @new;
        }

        // PUT: api/News/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNew(int id, New @new)
        {
            if (id != @new.ID)
            {
                return BadRequest();
            }

            _context.Entry(@new).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
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

            return NoContent();
        }

        // POST: api/News
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<New>> PostNew(New @new)
        {
            _context.News.Add(@new);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNew", new { id = @new.ID }, @new);
        }

        // DELETE: api/News/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<New>> DeleteNew(int id)
        {
            var @new = await _context.News.FindAsync(id);
            if (@new == null)
            {
                return NotFound();
            }

            _context.News.Remove(@new);
            await _context.SaveChangesAsync();

            return @new;
        }

        private bool NewExists(int id)
        {
            return _context.News.Any(e => e.ID == id);
        }
    }
}
