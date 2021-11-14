using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WindowsLoginSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class saveNewPassController : ControllerBase
    {
        // GET: api/saveNewPass
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/saveNewPass/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "aaaaa";//new string[] { "value1", "value2" };
        }

        // GET api/Guid/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST: api/saveNewPass
        [HttpPost]
        public void Post([FromBody] myData value)
        {
            string id = value.id;
            string password = value.password;
            string oneTimePass = value.ticks;
            DateTime timeOff = DateTime.Now.AddMinutes(5);

            UserData userData = new UserData() { password=password, oneTimePass = oneTimePass, timeOff= timeOff };

            if (Globals.data.ContainsKey(id))
                Globals.data.Remove(id);

            Globals.data.Add(id,userData);
        }

        // PUT: api/saveNewPass/5
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


    public class myData
    {
        public string id { get; set; }
        public string password { get; set; }
        public string ticks { get; set; }

    }
}
