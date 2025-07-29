using UserManagementAPI.Models;

namespace UserManagementAPI.Services
{
    // This class implements the IUserService interface and provides methods to manage users.
    public class UserService : IUserService
    {
        // In-memory list to simulate a database for demonstration purposes.
        private readonly List<User> _users;

        // Constructor initializes the user list with some sample data.
        public UserService()
        {
            // Sample data for demonstration purposes.
            _users = new List<User>
            {
                new User { Id = 1, FullName = "Alice Smith", Email = "alice@example.com", Role = "Admin", IsActive = true },
                new User { Id = 2, FullName = "Bob Jones", Email = "bob@example.com", Role = "User", IsActive = true },
                new User { Id = 3, FullName = "Charlie Brown", Email = "charlie@example.com", Role = "User", IsActive = false }
            };
        }

        // This method retrieves all users and maps them to UserDto objects.
        public List<UserDto> GetAllUsers()
        {
            return _users.Select(u => new UserDto
            {
                Id = u.Id,
                FullName = u.FullName,
                Email = u.Email
            }).ToList();
        }

        // This method retrieves a user by their ID and maps it to a UserDto object.
        public UserDto GetUserById(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null) return null;
            return new UserDto
            {
                Id = user.Id,
                FullName = user.FullName,
                Email = user.Email
            };
        }

        // This method creates a new user based on the provided UserDto.
        public void CreateUser(UserDto userDto)
        {
            var newUser = new User
            {
                Id = _users.Max(u => u.Id) + 1,
                FullName = userDto.FullName,
                Email = userDto.Email,
                Role = "User",
                IsActive = true
            };
            _users.Add(newUser);
        }

        // This method updates an existing user based on the provided UserDto.
        public void UpdateUser(int id, UserDto userDto)
        {
            var existingUser = _users.FirstOrDefault(u => u.Id == id);
            if (existingUser == null) return;

            existingUser.FullName = userDto.FullName;
            existingUser.Email = userDto.Email;
        }

        // This method deletes a user by their ID.
        public void DeleteUser(int id)
        {
            var userToDelete = _users.FirstOrDefault(u => u.Id == id);
            if (userToDelete != null)
            {
                _users.Remove(userToDelete);
            }
        }
    }
}
