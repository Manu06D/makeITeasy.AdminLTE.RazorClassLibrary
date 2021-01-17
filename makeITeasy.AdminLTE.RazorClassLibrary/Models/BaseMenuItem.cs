namespace makeITeasy.AdminLTE.RazorClassLibrary.Models
{
    public class BaseMenuItem
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string CssClass { get; set; }
        public MenuItemType Type { get; set; }
    }
}