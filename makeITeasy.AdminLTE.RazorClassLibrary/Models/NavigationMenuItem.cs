using System.Collections.Generic;

namespace makeITeasy.AdminLTE.RazorClassLibrary.Models
{
    public class NavigationMenuItem : BaseMenuItem
    {
        public Badge Badge { get; set; }

        public ICollection<NavigationMenuItem> Items { get; set; }
    }
}