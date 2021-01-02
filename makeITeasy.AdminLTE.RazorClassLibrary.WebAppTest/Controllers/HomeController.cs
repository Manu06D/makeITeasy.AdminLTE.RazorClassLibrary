using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using makeITeasy.AdminLTE.RazorClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace makeITeasy.AdminLTE.RazorClassLibrary.WebAppTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PageDefinition _pageDefinition;
        public HomeController(ILogger<HomeController> logger, PageDefinition pageDefinition)
        {
            _logger = logger;
            _pageDefinition = pageDefinition;
        }

        public IActionResult Index()
        {
            _pageDefinition.Title = "WebAppTest - Welcome";
            return View();
        }
    }
}
