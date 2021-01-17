using System.Collections.Generic;
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
        public NavigationTypeEnum NavigationType => NavigationTypeEnum.Default;

        public NavBarHeaderInformation NavBarInformation => new NavBarHeaderInformation()
        {
            LogoAltText = "Admin LTE Logo",
            LogoUrl = "/lib/admin-lte/img/AdminLTELogo.png",
            SiteLink = _linkGenerator.GetPathByAction("Index", "Home"),
            SiteTitle = "AdminLTE 3"
        };

        public NavBarMenu NavBarMenu => new NavBarMenu()
        {
            Items = new List<NavBarMenuItem>
            {
                new NavBarMenuItem{ Link = _linkGenerator.GetPathByAction("Index", "Home"), Title = "Home"},
                new NavBarMenuItem{ Link = "#", Title = "Contact"},
                new NavBarMenuItem{ Link = "#", Title = "Help", CssClass = "bg-info rounded",
                Items = new List<NavBarMenuItem>
                    {
                        new NavBarMenuItem{ Link = "#", Title = "FAQ"},
                        new NavBarMenuItem{ Link = "#", Title = "Support"},
                        new NavBarMenuItem{ Type = MenuItemType.Divider},
                        new NavBarMenuItem{ Link = "#", Title = "Contact"},
                    }
                }
            }
        };

        public NavigationMenu NavigationMenu => new NavigationMenu()
        {
            DisplaySearch = true,
            Items = new List<NavigationMenuItem>
            {
                new NavigationMenuItem { Title = "Dashboard",
                    CssClass = "fas fa-tachometer-alt",
                    Items = new List<NavigationMenuItem>()
                    {
                        new NavigationMenuItem(){Title = "Dashboard v1", Link = _linkGenerator.GetPathByAction("Dashboard1", "Home"), CssClass = "far fa-circle"},
                        new NavigationMenuItem(){Title = "Dashboard v2", Link = _linkGenerator.GetPathByAction("Dashboard2", "Home"), CssClass = "far fa-circle"}
                    }
                },
                new NavigationMenuItem { Title = "Main Navigation", Type = MenuItemType.Divider},
                new NavigationMenuItem{
                    Link = _linkGenerator.GetPathByAction("Index", "Home"), Title = "Simple Link",
                    CssClass = "fas fa-th",
                    Badge = new Badge(){Message = "New", Level = DataLevel.Danger}
                },
                new NavigationMenuItem{ 
                    Link = _linkGenerator.GetPathByAction("LoginV2", "Example"), 
                    Title = "Login V2", CssClass = "fas fa-circle"},
                new NavigationMenuItem { Title = "MULTI LEVEL EXAMPLE", Type = MenuItemType.Divider},
                new NavigationMenuItem{ Link = "#", Title = "Level 1", CssClass = "fas fa-circle"},
                new NavigationMenuItem{ Link = "#", Title = "Level 1", CssClass = "fas fa-circle",
                    Items = new List<NavigationMenuItem>()
                    {
                        new NavigationMenuItem{ Link = "#", Title = "Level 2", CssClass = "far fa-circle"},
                        new NavigationMenuItem{ Link = "#", Title = "Level 2", CssClass = "far fa-circle",
                            Items = new List<NavigationMenuItem>()
                            {
                                new NavigationMenuItem{ Link = "#", Title = "Level 3", CssClass = "far fa-dot-circle"},
                                new NavigationMenuItem{ Link = "#", Title = "Level 3", CssClass = "far fa-dot-circle"},
                                new NavigationMenuItem{ Link = "#", Title = "Level 3", CssClass = "far fa-dot-circle"},
                            }
                         },
                        new NavigationMenuItem{ Link = "#", Title = "Level 2", CssClass = "far fa-circle"},
                    }
                },
                new NavigationMenuItem{ Link = "#", Title = "Level 1", CssClass = "fas fa-circle"},
                new NavigationMenuItem { Title = "Starter Pages", Type = MenuItemType.Divider},
                new NavigationMenuItem{ Link = "#", Title = "Starter Pages", CssClass = "fas fa-tachometer-alt",
                    Items = new List<NavigationMenuItem>()
                    {
                        new NavigationMenuItem{ Link = "#", Title = "Active Page", CssClass = "far fa-circle"},
                        new NavigationMenuItem{ Link = "#", Title = "Inactive Page", CssClass = "far fa-circle"}
                    }
                }
            }
        };
    }
}
