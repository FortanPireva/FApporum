using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : BaseController
    {

        [HttpGet]
        public string GetHome()
        {
            return "home";
        }
    }
}
