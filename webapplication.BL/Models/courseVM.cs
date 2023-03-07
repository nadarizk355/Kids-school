using AdminDashboard.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminDashboard.BLL.Models
{
    internal class courseVM
    {
        public class course
        {
            public int Id { get; set; }
            [ForeignKey("lecture")]
            public int idlecture { get; set; }
            public string Name { get; set; }
            public double coast { get; set; }
            public List<student_cource> student_Cources { get; set; }
            public List<session> session { get; set; }
            public lecturer lecture { get; set; }
        }
    }
}
