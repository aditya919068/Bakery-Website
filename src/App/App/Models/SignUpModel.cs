using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class SignUpModel
    {
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50, ErrorMessage = "Name should not be gratter then 50 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [MaxLength(50, ErrorMessage = "Email should not be gratter then 50 characters")]
        [EmailAddress]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter vaild email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MaxLength(50, ErrorMessage = "Password should not be gratter then 50 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [MaxLength(100, ErrorMessage = "Address should not be gratter then 100 characters")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [MaxLength(15, ErrorMessage = "Phone number should not be gratter then 15 characters")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}