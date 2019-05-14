using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplicationQuizz2.Controllers
{
    [RoutePrefix("api/user")]
    public class UsersController : ApiController
    {
        // GET: Users
        [HttpGet, Route("")]
        public IHttpActionResult Get()
        {
            List<User> result = BusinessLogics.getAllUsers().ToList();
            IList<Users> users = Mapper.Map<List<User>, List<Users>>(result);
            if (users.Count == 0)
            {
                return NotFound();
            }
            return Ok(users);
        }

        [HttpGet, Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            Users subject = Mapper.Map<User,Users>(BusinessLogics.findUser(id));
            if (subject == null)
            {
                return NotFound();
            }

            return Ok(subject);
        }

        [HttpPost, Route("")]
        public IHttpActionResult Post([FromBody]Users subject)
        {
            User s = Mapper.Map<Users, User>(subject);
            bool success = BusinessLogics.addUser(s);
            if (success)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Invalid data");
            }
        }

        [HttpPut, Route("")]
        public IHttpActionResult Put([FromBody]User user)
        {
            bool success = BusinessLogics.updateUser(user);
            if (success)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Invalid data");
            }
        }

        [HttpDelete, Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            bool success = BusinessLogics.deleteUser(id);
            if (success)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Invalid data");
            }
        }
    }
}