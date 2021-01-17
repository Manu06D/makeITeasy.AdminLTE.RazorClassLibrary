using System;

namespace makeITeasy.AdminLTE.RazorClassLibrary.Attributes
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]

    public class WebSitePageAttribute : Attribute
    {
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
