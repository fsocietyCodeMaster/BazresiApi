using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class LoginDto
    {
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email {  get; set; }

        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
