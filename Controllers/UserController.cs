using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;
using UserManagementAPI.Services;

namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/user
        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }

        // GET: api/user/{id}
        [HttpGet("{id}")]
        public ActionResult<UserDto> GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            return user != null ? Ok(user) : NotFound();
        }

        // POST: api/user
        [HttpPost]
        public ActionResult CreateUser([FromBody] UserDto userDto)
        {
            if (userDto == null || string.IsNullOrWhiteSpace(userDto.FullName) || string.IsNullOrWhiteSpace(userDto.Email))
            {
                return BadRequest("Invalid user data.");
            }
            _userService.CreateUser(userDto);
            return CreatedAtAction(nameof(GetUserById), new { id = userDto.Id }, userDto);
        }

        // PUT: api/user/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, [FromBody] UserDto userDto)
        {
            if (userDto == null || string.IsNullOrWhiteSpace(userDto.FullName) || string.IsNullOrWhiteSpace(userDto.Email))
            {
                return BadRequest("Invalid user data.");
            }
            var existingUser = _userService.GetUserById(id);
            if (existingUser == null)
            {
                return NotFound();
            }
            _userService.UpdateUser(id, userDto);
            return NoContent();
        }

        // DELETE: api/user/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var existingUser = _userService.GetUserById(id);
            if (existingUser == null)
            {
                return NotFound();
            }
            _userService.DeleteUser(id);
            return NoContent();
        }
    }
}
