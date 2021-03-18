using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Entity
{
    public class UserRegistration 
    {
        [Required]
        public string FullName { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string UserName { get; set; }

    }
}
