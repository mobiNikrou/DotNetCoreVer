using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotNetCoreVer1.Models;
using DotNetCoreVer1.InterFaces;
using DotNetCoreVer1.Data;
using DotNetCoreVer1.Infrastructure;

namespace DotNetCoreVer1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
        }

        [HttpGet]
        public IActionResult Index()
        {
            IHandelInputData myService = ServiceLocator.Current.GetInstance<IHandelInputData>();
            myService.HelloWorld();
            return View();
        }

        [HttpPost]
        public ActionResult HandelForm(HandelInputData handelinputdata,Test FormVal) 
        {
            handelinputdata.LocalRoute(FormVal);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
