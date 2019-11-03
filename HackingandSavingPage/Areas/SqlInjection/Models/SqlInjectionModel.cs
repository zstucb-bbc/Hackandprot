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


    }
}
