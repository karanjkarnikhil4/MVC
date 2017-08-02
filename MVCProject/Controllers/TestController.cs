using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCProject.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string  GetString()
        {
            return "Hello this is my first mvc project";
        }
    }
}