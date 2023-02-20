using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace webapplication.BL.Models
{
    public class ForgetPasswordVM
    {

            [Required(ErrorMessage = "This Field Required")]
            [EmailAddress(ErrorMessage = "Invalid Mail")]
            public string Email { get; set; }
        

    }
}
