using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TagGame.Controllers
{
    public class TagGameController : Controller
    {
        public IActionResult Start()
        {
            return View();
        }

        public IActionResult Play()
        {
            return View();
        }

    }
}
