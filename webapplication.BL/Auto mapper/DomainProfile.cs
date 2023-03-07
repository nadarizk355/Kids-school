using AdminDashboard.BLL.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using webapplication.BL.Models;
using webapplication.DAL.entity1;
using static System.Collections.Specialized.BitVector32;

namespace webapplication.BL.Auto_mapper
{
    internal class DomainProfile : Profile
    {
       
            public DomainProfile()
            {
                CreateMap<admin, adminVM>();
                CreateMap<adminVM, admin>();

                CreateMap<Communications, communicationVM>();
                CreateMap<communicationVM, Communications>();

                CreateMap<course, courseVM>();
                CreateMap<courseVM, course>();

                CreateMap<lecturer, lecturerVM>();
                CreateMap<lecturerVM, lecturer>();

                CreateMap<lectuerstudent, lecturerstudentVM>();
                CreateMap<lecturerstudentVM, lectuerstudent>();

                CreateMap<parent, parentVM>();
                CreateMap<parentVM, parent>();

                CreateMap<session, sessionVM>();
                CreateMap<sessionVM, session>();

                CreateMap<student_cource, student_courseVM>();
                CreateMap<student_courseVM, student_cource>();


                CreateMap<student, studentVM>();
                CreateMap<studentVM, student>();

                CreateMap<Task, taskVM>();
                CreateMap<taskVM, Task>();



            }



        }


    }

