using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Instructor : IEntity
    {
        public int Id { get ; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorLastName { get; set; }
        public string InstructorAbout { get; set; }
    }
}
