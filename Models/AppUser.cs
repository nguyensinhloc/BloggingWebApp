using Microsoft.AspNetCore.Identity;

namespace BloggingWebApp.Models
{
    public class AppUser : IdentityUser
    {
        public string Job {  get; set; }
    }
}
