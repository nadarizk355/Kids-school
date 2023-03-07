using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdminDashboard.BLL.Models.communicatVM;
using static AdminDashboard.BLL.Models.lecturerstudentVM;
using static AdminDashboard.BLL.Models.parentVM;
using static AdminDashboard.BLL.Models.student_courseVM;
using static AdminDashboard.BLL.Models.taskVM;

namespace AdminDashboard.BLL.Models
{
    internal class studentVM
    {
        public class student
        {
            public int Id { get; set; }
            [ForeignKey("parent")]
            public int idparent { get; set; }

            public string Name { get; set; }

            public int birthday { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public string photo { get; set; }
            public string description { get; set; }
            public string gender { get; set; }
            public List<lectuerstudent> lectuerstudent { get; set; }
            public List<student_cource> student_Cources { get; set; }
            public List<tasks> tasks { get; set; }
            public List<Communications> Communications { get; set; }
            public parent parent { get; set; }

        }
    }
}
