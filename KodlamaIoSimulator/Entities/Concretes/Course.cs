using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Course : IEntity
    {
        public int Id { get ; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseInstructorName { get; set; }

    }
}
