using System.ComponentModel.DataAnnotations;
using static CalorieDiaryCalculator.Server.Data.Validation.User;

namespace CalorieDiaryCalculator.Server.Features.Identity
{
    public class RegisterRequestModel
    {
        [Required]
        [MinLength(MinUserNameLength)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
