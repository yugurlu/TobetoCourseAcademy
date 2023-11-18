using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class CourseDetail:IDto
    {
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
        public string CategoryName { get; set; }
        public double CoursePrice { get; set; }
        public string CourseImage { get; set; }
        public string CourseDescription { get; set; }

    }
}
