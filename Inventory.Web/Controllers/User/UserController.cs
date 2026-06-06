//using Inventory.Web.Database.Contexts;
//using Inventory.Web.Database.Entities;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace Inventory.Web.Controllers.UserController {

//    [ApiController]
//    [Route("Api/[Controller]")]
//    public class UserController(InventoryDbContext dbContext) : ControllerBase {
        
//        private readonly InventoryDbContext _context = dbContext;



//        [HttpGet("{id}")]
//        public async Task<IActionResult> GetUserName(string id) {

//            var user = await _context.Users.FirstOrDefaultAsync(p => p.Id == id);

//            if (user == null) 
//                return NotFound();

//            return Ok(user.UserName);

//        }


//        [HttpPost]
//        public async Task<IActionResult> CreateUser([FromBody] User user) {
//            if (user == null) {
//                return BadRequest("User data is required.");
//            }

//            try {
//                // Assuming you have a DbContext injected (e.g., ApplicationDbContext)
//                _context.Users.Add(user);
//                await _context.SaveChangesAsync();

//                return Ok(new { message = "User created successfully", userId = user.Id });
//            }
//            catch (Exception ex) {
//                // Log the exception if needed
//                return StatusCode(500, new { message = "Error creating user", error = ex.Message });
//            }
//        }



//    }
//}
