using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using API.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ApplicationUsersController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public ApplicationUsersController(AppDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> GetAllAccount()
        {
            return await _db.ApplicationUsers.ToListAsync();
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ApplicationUser>> GetUserById(string id)
        {
            return await _db.ApplicationUsers.Where(u => u.Id == id).FirstOrDefaultAsync();
        }
        [HttpPost]
        public async Task<ActionResult<ApplicationUser>> CreateAccount(ApplicationUser user, string role)
        {
            var result = _userManager.CreateAsync(user).GetAwaiter().GetResult();
            if (result.Succeeded)
            {
                if (!await _roleManager.RoleExistsAsync(Helper.ADMIN_ROLE))
                {
                    await _roleManager.CreateAsync(new IdentityRole(Helper.ADMIN_ROLE));
                }
                if (!await _roleManager.RoleExistsAsync(Helper.MANAGER_ROLE))
                {
                    await _roleManager.CreateAsync(new IdentityRole(Helper.MANAGER_ROLE));
                }
                if (!await _roleManager.RoleExistsAsync(Helper.CUSTOMER_ROLE))
                {
                    await _roleManager.CreateAsync(new IdentityRole(Helper.CUSTOMER_ROLE));
                }
                if (role.Equals(Helper.ADMIN_ROLE) || role.Equals(Helper.CUSTOMER_ROLE) || role.Equals(Helper.MANAGER_ROLE))
                {
                    await _userManager.AddToRoleAsync(user, role);
                }
                else
                {
                    await _userManager.AddToRoleAsync(user,Helper.CUSTOMER_ROLE);
                }
                return user;
            }
            return BadRequest();
        }
    }
}
