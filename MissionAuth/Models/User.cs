using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissionAuth.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required, DisplayName("Email"), StringLength(50, MinimumLength = 3, ErrorMessage = "Email must be between 3 and 50 characters long."),
            EmailAddress(ErrorMessage = "Improper email format.")]
        public String UserEmail { get; set; }
        [Required, DisplayName("Password"), StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 50 characters long.")]
        public String UserPassword { get; set; }
        [DisplayName("First Name"), StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters long."),
            RegularExpression(@"^[A-Z][a-zA-Z.\- ]*$", ErrorMessage = "Capitalize last name. -. symbols allowed only.")]
        public String UserFirstName { get; set; }
        [DisplayName("Last Name"), StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters long."),
            RegularExpression(@"^[A-Z][a-zA-Z.\- ]*$", ErrorMessage = "Capitalize last name. -. symbols allowed only.")]
        public String UserLastName { get; set; }
    }
}