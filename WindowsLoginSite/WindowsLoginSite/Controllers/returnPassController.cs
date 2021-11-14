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
    public class returnPassController : ControllerBase
    {
        // POST: api/returnPass
        [HttpPost]
        public string Post([FromBody] myPass value)
        {
            string id = value.id;
            string oneTimePass = value.password;

            if (Globals.data.ContainsKey(id) && Globals.data[id].oneTimePass == oneTimePass && Globals.data[id].timeOff >= DateTime.Now)
                return Globals.data[id].password;
            else
                return "";
        }
    }

    public class myPass
    {
        public string id { get; set; }
        public string password { get; set; }
        

    }
}
