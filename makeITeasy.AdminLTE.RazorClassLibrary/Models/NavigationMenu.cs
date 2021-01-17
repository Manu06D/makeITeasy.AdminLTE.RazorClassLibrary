using System.Collections.Generic;

namespace makeITeasy.AdminLTE.RazorClassLibrary.Models
{
    public class NavigationMenu
    {
        public ICollection<NavigationMenuItem> Items { get; set; }
        public bool DisplaySearch { get; set; } = true;
    }
}