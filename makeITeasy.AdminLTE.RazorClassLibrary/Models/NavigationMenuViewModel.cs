
using System.Collections.Generic;

namespace makeITeasy.AdminLTE.RazorClassLibrary.Models
{
    public class NavigationMenuViewModel
    {
        public ICollection<NavigationMenuItem> Items { get; set; }
        public int Level { get; set; }

        public NavigationMenuViewModel(ICollection<NavigationMenuItem> items, int level = 0)
        {
            Items = items;
            Level = level;
        }
    }
}
