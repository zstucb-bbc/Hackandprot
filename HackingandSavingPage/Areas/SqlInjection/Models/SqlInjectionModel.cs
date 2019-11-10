using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackingandSavingPage.Areas.SqlInjection.Models
{
    public class SqlInjectionModel
    {
        [DisplayName("User Name")]
        [Required]
        public String UserName { get; 
            set; }

        [DisplayName("Email")]
        [Required]
        public String Email
        {
            get;
            set;
        }

        [DisplayName("Password")]
        [Required]
        [StringLength(10, ErrorMessage = "The password must be atleast 10 Characters")]

        public String Password
        {
            get;
            set;
        }

        [DisplayName("Enter your Email again")]
        [Required]
        public String RepeatEmail
        {
            get;
            set;
        }

        [DisplayName("Married?")]
        public bool Married
        {
            get;set;
        }

        [DisplayName("Your Birthday")]
        public DateTime Birthdate
        {
            get; set;
        }





    }
}
