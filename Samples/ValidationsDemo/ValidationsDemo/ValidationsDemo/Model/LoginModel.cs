using System.ComponentModel.DataAnnotations;
namespace ValidationsDemo.Model
{
    public class LoginModel
    {
        [Required, MaxLength(20), EmailAddress]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public bool Rememberme { get; set; }
    }
}