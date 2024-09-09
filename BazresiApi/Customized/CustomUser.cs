using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BazresiApi.Customized
{
    public class CustomUser : IdentityUser
    {
        [StringLength(50)]

        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

    }
}
