using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ResetPasswordDto
    {
        public String? UserName { get; init; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public String? Password { get; init; }

        [Required(ErrorMessage = "ConfirmPassword is required.")]
        [Compare("Password",ErrorMessage ="Password and ConfirmPassword do not match.")]
        [DataType(DataType.Password)]
        public String? ConfirmPassword { get; init; }
    }
}