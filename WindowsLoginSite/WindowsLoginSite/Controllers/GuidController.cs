using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;

namespace WindowsLoginSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuidController : ControllerBase
    {
        

        // GET api/Guid
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            string id;// Guid.NewGuid().ToString();
            id = "{c7cdf2ed-cc9e-45c9-b042-9ca240e207a8}";

            return Ok(id);
        }

            // GET api/Guid/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST: api/Guid
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Guid/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    public class inDictionary
    {
        public string id { get; set; }
        public string password { get; set; }
        public string oneTimePass { get; set; }

    }
}

