using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserRegistionApp.Web.ViewModels;
using UserRegistrationApp;

namespace UserRegistionApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly People _people;
        public UsersController(People people)
        {
            _people = people;
        }
        [HttpGet]
        [Route("GetAllUsers")]
        public IEnumerable<UserDetails> Get()
        {
            var users = _people.ViewAllUsersDetails();
            return users.Select(x => new UserDetails() { Id = x.Id, Name = x.Name, Email = x.Email });

        }

        [HttpPost]
        [Route("CreateUsers")]
        public bool Create( string name, string email)
        {
            var users = _people.AddAUser(name, email);
            return true;
        }

        [HttpPut]
        [Route("UpdateUser")]
        public bool Update(string email, string newName, string newEmail)
        {
            var users = _people.UpdateUserDetails(email, newName, newEmail);
            return true;
        }

        [HttpDelete]
        [Route("DeleteUser")]
        public bool Delete(string email)
        {
            var users = _people.DeleteUserDetails(email);

            return true;
        }
    }
}
