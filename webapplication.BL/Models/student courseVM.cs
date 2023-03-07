using AdminDashboard.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminDashboard.BLL.Models
{
    internal class student_courseVM
    {
        public class student_cource
        {
            [ForeignKey("student")]

            public int idstudent { get; set; }

            [ForeignKey("course")]
            public int idcourse { get; set; }
            public student student { get; set; }

            public course course { get; set; }
        }
    }
}
