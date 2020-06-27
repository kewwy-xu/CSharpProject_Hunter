using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HunterApi.Models;
using System.Collections.Generic;
using HunterApi.Common;
namespace HunterApi.Controllers
{
    [ApiController]
    [Route("api/hunter/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly HunterContext hunterDB;

        public UserController(HunterContext context)
        {
            hunterDB = context;
        }

        [HttpGet]
        public ActionResult get()
        {
            return NoContent();
        }

        [HttpGet("getUserInfoByUserId")]
        public ActionResult<User> GetUserInfoByUserId(int userId)
        {
            try
            {
                var user_temp = hunterDB.Users.FirstOrDefault(t => t.UserId == userId);
                return user_temp;
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

        [HttpGet("getUserInfoByUserName")]
        public ActionResult<User> GetUserInfoByUserName(string userName)
        {
            try
            {
                var user_temp = hunterDB.Users.FirstOrDefault(t => t.UserName == userName);
                return user_temp;
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

        //注册
        //访问路径：api/hunter/user/register?
        [HttpPost("register")]
        public ActionResult<User> Register(User user)
        {
            try
            {
                //查询用户名，邮箱是否重复
                var user_temp1 = hunterDB.Users.FirstOrDefault(t => t.UserName == user.UserName);
                var user_temp2 = hunterDB.Users.FirstOrDefault(t => t.Email == user.Email);
                if (user_temp1 == null && user_temp2 == null)
                {
                    hunterDB.Users.Add(user);
                    hunterDB.SaveChanges();
                    return user;
                }
                else
                    return NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

        //通过邮箱或用户名登录
        [HttpGet("login")]
        public ActionResult<int> Login(String userNameOrEmailAddress, String password)
        {
            var user_temp = hunterDB.Users.FirstOrDefault(t => t.UserName == userNameOrEmailAddress);
            if (user_temp == null)
            {
                return 0;
            }
            else if (user_temp.Password == password)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        //邮箱验证登录
        [HttpGet("email")]
        public ActionResult<User> EmailLogin(string EmailAddress)
        {
            //查询邮箱是否存在
            var user_temp1 = hunterDB.Users
                .FirstOrDefault(t => t.Email == EmailAddress);
            if (user_temp1 != null)
            {
                return user_temp1;
            }
            else
                return null;
        }

        //修改个人中心显示出来的个人信息
        [HttpPut("alterPersonalInfo")]
        public ActionResult<User> AlterPersonalInfo(int userId,User user)
        {
            if (userId != user.UserId)
            {
                return BadRequest("Id cannot be modified!");
            }
            else
            {
                hunterDB.Entry(user).State = EntityState.Modified;
                hunterDB.SaveChanges();
            }
            return user;
        }

        
        //选择偏好
        [HttpPost("choosePreferences")]
        public ActionResult ChoosePreferences(Preference preference)
        {
            hunterDB.Preferences.Add(preference);
            hunterDB.SaveChanges();
            return NoContent();
        }

        [HttpGet("getUserPreferences")]
        public ActionResult<List<ItemTypes>> GetUserPreferences(int userId)
        {
            var query = hunterDB.Preferences.Where(t => t.UserId == userId);
            List<ItemTypes> result = new List<ItemTypes>();
            foreach(var q in query)
            {
                result.Add(q.ItemType);
            }
            return result;
        }

      
    }
}
