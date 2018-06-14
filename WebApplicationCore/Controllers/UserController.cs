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
using Newtonsoft.Json;
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
            return DataSourceLoader.Load(context.Users.Select(s => new UserModel { UserId = s.Id, UserName = s.UserName, Email = s.Email}), loadOptions);
            
           //return DataSourceLoader.Load(context.Users.Select(s => new UserModel { Id = s.Id, UserName = s.UserName, Email = s.Email }), loadOptions);
        }

        private object IdentityDbContext<T>()
        {
            throw new NotImplementedException();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public object Get(int id)
        {
            DataSourceLoadOptions loadOptions = new DataSourceLoadOptions();
            return DataSourceLoader.Load(context.Users.Select(s => new UserModel { UserId = s.Id, UserName = s.UserName, Email = s.Email }), loadOptions);
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
