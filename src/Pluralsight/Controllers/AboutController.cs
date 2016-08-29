using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pluralsight.Controllers
{
    [Route("[controller]")]
    public class AboutController
    {
        [Route("")]
        public string Phone()
        {
            return "23423423423";
        }
        [Route("[action]")]
        public string Country()
        {
            return "Aus";
        }
    }
}
