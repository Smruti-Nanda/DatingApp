using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username{ get; set; }

        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage ="Must specify password within 4 and 8 characters")]
        public string Password { get; set; }
    }
}