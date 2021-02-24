using System.ComponentModel.DataAnnotations;

namespace ChatApplication.Data.DTOs
{
    public class LoginDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        
    }
}