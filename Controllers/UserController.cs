using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Model;
using WebApi.Dummy;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private List<User> _users = DummyData.GetUsers(200);


        [HttpGet]
        public List<User> Get()
        {
            return _users;
        }


        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        [HttpPost]
        public User Post([FromBody]User user)
        {
            _users.Add(user);
            return user;
        }

    }
}
