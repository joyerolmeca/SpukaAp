using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpukaAp.Models;

namespace SpukaAp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly spukaContext _context;

        public ValuesController(spukaContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        /*
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        } */


        public IActionResult Get()
        {
            List<TAdressen> direcciones = _context.TAdressen
              .AsNoTracking()
              .ToList();

            return Ok(direcciones);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
