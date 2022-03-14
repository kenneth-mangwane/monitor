using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBS.API.Controllers
{
    public class CityController : Controller
    {
        public IActionResult AvailableCitie()
        {
            return View();
        }
    }
}
