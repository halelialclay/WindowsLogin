using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsLoginSite
{
    public class Globals
    {
        public static Dictionary<string, UserData> data = new Dictionary<string, UserData>();
    }

    public class UserData {
        public string password { get; set; }
        public string oneTimePass { get; set; }
        public DateTime timeOff{get; set;}
    }
}
