using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record UserDto
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="UserName is required.")]
        public String? UserName { get; init; }
        
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Email is required.")]
        public String? Email { get; init; }
        
        [DataType(DataType.PhoneNumber)]
        public String? PhoneNumber { get; init; }
        
        public HashSet<String> Roles { get; set; } = new HashSet<string>();
    }
}