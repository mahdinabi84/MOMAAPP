using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOMAAPP.Areas.Prison.Controllers
{
    [Route("Prison")]
    public class PrisonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
