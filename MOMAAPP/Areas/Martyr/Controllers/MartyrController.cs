using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOMAAPP.Areas.Martyr.Controllers
{
    [Route("Martyr")]
    public class MartyrController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
