using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Admins.Models
{
    public class LoginAdminsViewModel
    {
        [Required(ErrorMessage = "Please enter your phone number ")]
        [DataType(DataType.PhoneNumber)]
        public int phone { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        [RegularExpression(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[\W]).{8,64})", ErrorMessage = "Password Must Include capital and lower letter and special char and minium length is 8")]
        public string Password { get; set; }
    }
}