using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotNetCoreVer1.Models;
using DotNetCoreVer1.Services;
using DotNetCoreVer1.Data;


namespace DotNetCoreVer1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHandleData _handleData;
        //TestResultContext _myService = ServiceLocator.Current.GetInstance<TestResultContext>();
        public HomeController(ILogger<HomeController> logger,IHandleData handleData)
        {
            _logger = logger;
            _handleData = handleData;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult HandelForm(Test FormVal) 
        {
            _handleData.LocalRoute(FormVal);
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
