using System.ComponentModel.DataAnnotations;

namespace BloggingWebApp.Models
{
    public class Login
    {
        [Required]
        public string UserName { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
