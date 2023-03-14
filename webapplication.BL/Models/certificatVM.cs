using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapplication.BL.Models
{
    public class certificatVM
    {

        [Required(ErrorMessage = "This course Required")]
        public string course { get; set; }

    }
}
