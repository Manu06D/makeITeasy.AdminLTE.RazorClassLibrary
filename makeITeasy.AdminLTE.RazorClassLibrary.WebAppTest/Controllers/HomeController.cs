using makeITeasy.AdminLTE.RazorClassLibrary.Attributes;
using makeITeasy.AdminLTE.RazorClassLibrary.Models;
using makeITeasy.AdminLTE.RazorClassLibrary.WebAppTest.Models;
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

        [WebSitePage(Title = "Home")]
        public IActionResult Index()
        {
            _pageDefinition.Title = "WebAppTest - Welcome";

            return View();
        }

        [WebSitePage(Title = "Dashboard1")]
        public IActionResult DashBoard1()
        {
            return View();
        }

        [WebSitePage(Title = "Dashboard2")]
        public IActionResult DashBoard2()
        {
            return View();
        }

        [WebSitePage(Title = "Empty")]
        public IActionResult Empty()
        {
            return View();
        }
    }
}
