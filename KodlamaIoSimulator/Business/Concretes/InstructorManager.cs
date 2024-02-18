using BusinessLayer.Abstract;
using DataAccsess.Concretes;
using DataAccsessLayer.Abstracts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public void TAdd(Instructor entity)
        {
            _instructorDal.Add(entity);
        }

        public void TDelete(Instructor entity)
        {
            _instructorDal.Delete(entity);
        }

        public void TUpdate(Instructor entity)
        {
            _instructorDal.Update(entity);
        }

        public List<Instructor> TGetAll()
        {
            return _instructorDal.GetAll();
        }

        public Instructor TGetById(int id)
        {
            return _instructorDal.GetById(id);
        }
    }
}
