using AdminDashboard.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminDashboard.BLL.Models
{
    internal class lecturerstudentVM
    {

        public class lectuerstudent
        {
            [ForeignKey("lecture")]
            public int idlectuer { get; set; }
            public lecturer lecture { get; set; }
            [ForeignKey("student")]
            public int idstudent { get; set; }

            public student student { get; set; }
        }
    }
}

