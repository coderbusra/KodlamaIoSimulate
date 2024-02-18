using DataAccsessLayer.Abstracts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructorDal;
        public InstructorDal()
        {
            List<Instructor> instructors1 = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    InstructorFirstName = "Engin ",
                    InstructorLastName = "Demiroğ",
                    InstructorAbout = "Yazılımcı"
                },

                new Instructor
                {
                    Id = 2,
                    InstructorFirstName = "Halit Enes",
                    InstructorLastName = "Kalaycı",
                    InstructorAbout = "Yazılımcı"
                }
            };
            _instructorDal = instructors1;
        }

        public void Add(Instructor entity)
        {
            _instructorDal.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            _instructorDal.Remove(entity);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal;
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.Where(c => c.Id == id).FirstOrDefault();
        }

        public void Update(Instructor entity)
        {
            var instructorUpDate = _instructorDal.FirstOrDefault(c => c.Id == entity.Id);

            if (instructorUpDate != null)
            {
                instructorUpDate.InstructorFirstName = entity.InstructorFirstName;
                instructorUpDate.InstructorLastName = entity.InstructorLastName;
                instructorUpDate.InstructorAbout = entity.InstructorAbout;
            }
        }
    }
}
