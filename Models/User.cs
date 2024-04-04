using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloggingWebApp.Models
{
    public class User
    {
        [Required, MinLength(2, ErrorMessage = "Minimum length is 2 characters")]
        public string UserName {  get; set; }
        [Required, DataType(DataType.Password), MinLength(4, ErrorMessage = "Minimum length is 4 characters")]
        public string Password { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }

        public User() { }

        public User(AppUser appUser)
        {
            UserName = appUser.UserName;
            Password = appUser.PasswordHash;
            Email = appUser.Email;
        }
    }
}
