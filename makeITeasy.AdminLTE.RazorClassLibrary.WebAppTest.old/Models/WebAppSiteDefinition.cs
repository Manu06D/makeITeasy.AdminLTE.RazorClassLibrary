using makeITeasy.AdminLTE.RazorClassLibrary.Models;
using Microsoft.AspNetCore.Routing;

namespace makeITeasy.AdminLTE.RazorClassLibrary.WebAppTest.Models
{
    public class WebAppSiteDefinition : ISiteDefinition
    {
        protected readonly LinkGenerator _linkGenerator;
        public WebAppSiteDefinition(LinkGenerator linkGenerator)
        {
            _linkGenerator = linkGenerator;
        }

        public NavBarHeaderInformation NavBarInformation => new NavBarHeaderInformation()
        {
            LogoAltText = "Admin LTE Logo",
            LogoUrl = "/lib/admin-lte/img/AdminLTELogo.png",
            SiteLink = _linkGenerator.GetPathByAction("Index", "Home"),
            SiteTitle = "AdminLTE 3"
        };
    }
}
