using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Models;
namespace HunterApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly HunterContext hunterDB;

        public OrderController(HunterContext context)
        {
            hunterDB = context;
        }

        [HttpGet("{NickName}")]
        public ActionResult<User> GetUser(string NickName)
        {
            var user = hunterDB.Users.FirstOrDefault(t => t.NickName == NickName);

            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return user;
            }           
        }

        // POST: api/user
        [HttpPost]
        public ActionResult<User> PostUser(User user)
        {
            try
            {
                hunterDB.Users.Add(user);               
                hunterDB.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return user;
        }

        // PUT: api/user/{NickName}
        [HttpPut("{NickName}")]
        public ActionResult<User> PutUser(string NickName, User user)
        {
            if (NickName != user.NickName)
            {
                return BadRequest("NickName cannot be modified!");
            }
            try
            {
                hunterDB.Entry(user).State = EntityState.Modified;
                hunterDB.SaveChanges();
                return user;
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }            
        }

        // DELETE: api/user/{NickName}
        [HttpDelete("{NickName}")]
        public ActionResult DeleteUser(string NickName)
        {
            try
            {
                var user = hunterDB.Users.Include("Posts").FirstOrDefault(t => t.NickName == NickName);
                if (user != null)
                {
                    hunterDB.Users.Remove(user);
                    hunterDB.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
