using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organize.Shared.Enitites
{
    public class User
    {
        [Required]
        [StringLength(10, ErrorMessage ="User name is too long.")]
        public string UserName{ get; set; }

        [Required(ErrorMessage = "The Password is requried!!!")]
        public string Password { get; set; }
        
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
