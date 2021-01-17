using makeITeasy.AdminLTE.RazorClassLibrary.Models;
using makeITeasy.AdminLTE.RazorClassLibrary.WebAppTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace makeITeasy.AdminLTE.RazorClassLibrary.WebAppTest.Controllers
{
    public class ExampleController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PageDefinition _pageDefinition;
        public ExampleController(ILogger<HomeController> logger, PageDefinition pageDefinition)
        {
            _logger = logger;
            _pageDefinition = pageDefinition;
        }

        public IActionResult LoginV2()
        {
            _pageDefinition.Title = "WebAppTest - Welcome";

            return View();
        }
    }
}
