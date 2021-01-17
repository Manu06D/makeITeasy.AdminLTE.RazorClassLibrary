using System.Collections.Generic;
using makeITeasy.AdminLTE.RazorClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace makeITeasy.AdminLTE.RazorClassLibrary.Areas.NavigationMenu
{
    [ViewComponent(Name = "NavigationMenu")]
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ICollection<NavigationMenuItem> items, int level = 0)
        {
            return View(new NavigationMenuViewModel(items, level));
        }
    }
}
