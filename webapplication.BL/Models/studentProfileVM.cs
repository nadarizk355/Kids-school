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
    public class studentProfileVM
    {
        

        public int Id { get; set; }
        [Required(ErrorMessage = "Id Is Required")]
        [ForeignKey("parent")]
        public int idparent { get; set; }
        [Required(ErrorMessage = "id Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Phone Is Required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Gender Is Required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "birthday Is Required")]
        public int birthday { get; set; }




        [Required(ErrorMessage = "Email Required")]
        [EmailAddress(ErrorMessage = "You Must Enter Valid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Min Lenth 6")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password Required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Min Lenth 6")]
        [Compare("Password", ErrorMessage = "Not Matching")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        public string photo { get; set; }
        public string description { get; set; }

        public List<lectuerstudent> lectuerstudent { get; set; }
        public List<student_cource> student_Cources { get; set; }
        public List<tasks> tasks { get; set; }
        public List<Communications> Communications { get; set; }
        public parent parent { get; set; }

     
        }
    }
     

       

       
       
       
       







   



