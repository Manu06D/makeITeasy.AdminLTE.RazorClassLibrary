namespace makeITeasy.AdminLTE.RazorClassLibrary.Models
{
    public class PageDefinition
    {
        public string Title { get; set; }

        public PageDefinition(IUserInformation userInformation)
        {
            UserInformation = userInformation;
        }

        public IUserInformation UserInformation { get; set; }
    }
}
