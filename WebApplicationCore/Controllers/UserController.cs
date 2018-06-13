using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationCore.Data;
using WebApplicationCore.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationCore.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private ApplicationDbContext context;
        public UserController(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        // GET: api/<controller>
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            //return context.Users.Select(s => new UserModel {  Id = s.Id, UserName = s.UserName, Email = s.Email});

            var list = new List<UserModel>()
            {
                new UserModel { Id = 1, UserName = "2", Email = "3"}
                ,new UserModel { Id = 2, UserName = "3", Email = "5"}
            };
            return  DataSourceLoader.Load(list, loadOptions);
        }

        private object IdentityDbContext<T>()
        {
            throw new NotImplementedException();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
