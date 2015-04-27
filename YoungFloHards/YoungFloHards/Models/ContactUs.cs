using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace YoungFloHards.Models
{
    public class ContactUs
    {
        [Display(Name = "NAME")]
        [Required(ErrorMessage = "Your name is required")]
        public string Name { get; set; }

        [Display(Name = "EMAIL")]
        [Required(ErrorMessage = "Your email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "MESSAGE")]
        [Required(ErrorMessage = "Your message of inquiry is required")]
        public string Message { get; set; }
    }
}
