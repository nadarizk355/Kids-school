using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdminDashboard.BLL.Models.courseVM;
using static AdminDashboard.BLL.Models.lecturerVM;

namespace AdminDashboard.BLL.Models
{
    internal class sessionVM
    {
        public class session
        {
            public int Id { get; set; }
            [ForeignKey("course")]
            public int idcourse { get; set; }
            [ForeignKey("lecture")]
            public int idlecture { get; set; } = 0;
            public string linkviedo { get; set; }
            public int sessiontime { get; set; }
            public course course { get; set; }
            public lecturer lecture { get; set; }
        }
    }
}
