using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Product : ControllerBase
    {
        // GET: api/<Product>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Product>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Product>
        [HttpPost]
        public string Post()
        {
            return "This is product Post operation";
        }

        // PUT api/<Product>/5
        [HttpPut("{id}")]
        public string Put()
        {
            return "This is product Put operation";
        }

        // DELETE api/<Product>/5
        [HttpDelete("{id}")]
        public string Delete()
        {
            return "This is product delete operation";
        }
    }
}
