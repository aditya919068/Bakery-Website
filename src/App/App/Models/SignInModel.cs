using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class SignInModel
    {
        [Required(ErrorMessage = "Email is required")]
        [MaxLength(50, ErrorMessage = "Email should not be gratter then 50 characters")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter vaild email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MaxLength(50, ErrorMessage = "Password should not be gratter then 50 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}