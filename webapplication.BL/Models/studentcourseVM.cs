using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webapplication.DAL.entity1;

namespace webapplication.BL.Models
{
   public class studentcourseVM
    {
        [ForeignKey("student")]
        [Required(ErrorMessage = "Id Is Required")]
        public int idstudent { get; set; }

        [ForeignKey("course")]
        [Required(ErrorMessage = "Id Is Required")]
        public int idcourse { get; set; }
        public student student { get; set; }

        public course course { get; set; }
    }
}

