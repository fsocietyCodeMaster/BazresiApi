using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class RegisterDto
    {
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(50)]
        public string PasswordConfirmed { get; set; }

        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public List<string> Roles { get; set; } 
    }
}
