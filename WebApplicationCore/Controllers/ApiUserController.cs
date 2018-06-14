using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationCore.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationCore.Controllers
{
    [Route("api/[controller]")]
    public class ApiUserController : Controller
    {
        private ApplicationDbContext context;
        public ApiUserController(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        // GET: api/<controller>
        [HttpGet]
        public List<IdentityUser> Get()
        {
            var users = context.Users.ToList();
            return users;
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
