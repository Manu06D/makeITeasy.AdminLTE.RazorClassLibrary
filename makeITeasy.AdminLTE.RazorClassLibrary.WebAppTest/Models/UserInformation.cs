using makeITeasy.AdminLTE.RazorClassLibrary.Models;

namespace makeITeasy.AdminLTE.RazorClassLibrary.WebAppTest.Models
{
    public class UserInformation : IUserInformation
    {
        public string Name { get; set; }
        public string AvatarUrl { get; set; }
    }
}
