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
    public class CommentsController : Controller
    {
        private readonly AppDbContext _db;
        public CommentsController(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comment>>> GetAllComment()
        {
            return await _db.Comments.ToListAsync();
        }
        
        [HttpGet]
        [Route("game/{id}")]
        public async Task<ActionResult<IEnumerable<Comment>>> GetAllCommentOfGame(int id)
        {
            var comments = await (from a in _db.Comments
                                  join b in _db.GameComments
           on a.ID equals b.CommentID
                                  where b.GameID == id
                                  select a).ToListAsync();
                                  if(comments == null)
                                  {
                                      return NotFound();
                                  }
            return Ok(comments);
        }
        [HttpGet]
        [Route("user/{id}")]
        public async Task<ActionResult<IEnumerable<Comment>>> GetCommentsOfUser(string id)
        {
            var comments = await (from a in _db.Comments
                                  join b in _db.GameComments
           on a.ID equals b.CommentID
                                  where a.ApplicationUserID == id
                                  select a).ToListAsync();
            if (comments == null)
            {
                return NotFound();
            }
            return Json(comments);
        }

    }
}
