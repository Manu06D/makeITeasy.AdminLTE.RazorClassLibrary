namespace makeITeasy.AdminLTE.RazorClassLibrary.Models
{
    public interface ISiteDefinition
    {
        NavigationTypeEnum NavigationType { get; }
        NavBarHeaderInformation NavBarInformation { get; }
        NavBarMenu NavBarMenu { get; }
        NavigationMenu NavigationMenu { get; }
    }
}
