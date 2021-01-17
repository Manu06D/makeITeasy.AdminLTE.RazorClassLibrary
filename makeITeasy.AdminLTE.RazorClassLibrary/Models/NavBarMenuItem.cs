using System;
using System.Collections.Generic;

namespace makeITeasy.AdminLTE.RazorClassLibrary.Models
{
    public class NavBarMenuItem : BaseMenuItem
    {
        public ICollection<NavBarMenuItem> Items { get; set; }
        public Guid Guid { get; } = Guid.NewGuid();
    }
}
