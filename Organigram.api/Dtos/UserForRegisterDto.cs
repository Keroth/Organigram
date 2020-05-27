using System.ComponentModel.DataAnnotations;

namespace Organigram.api.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 Characters long")]
        public string Password { get; set; }
    }
}