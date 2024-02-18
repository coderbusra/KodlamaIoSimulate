using DataAccsessLayer.Abstracts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concretes
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courseDal;
        public CourseDal()
        {
            List<Course> course1 = new List<Course>
            {
                new Course
                {
                    Id = 1,
                    CourseName = "Yazılım Geliştirici Yetiştirme Kampı",
                    CourseDescription = "Senior (.NET)",
                    CourseInstructorName = "Engin Demiroğ",
                },
                new Course 
                {
                    Id = 2,
                    CourseName = "Yazılım Geliştirici Yetirme Kampı",
                    CourseDescription = " (C# + Angular)",
                    CourseInstructorName = "Engin Demiroğ"
                },
                new Course 
                {
                    Id = 3,
                    CourseName = "Yazılım Geliştirici Yetiştirme Kampı",
                    CourseDescription = "Python & Selenium",
                    CourseInstructorName = "Halit Enes Kalaycı",
                }
            };
            _courseDal = course1;
        }
        public void Add(Course entity)
        {
            _courseDal.Add(entity);
        }

        public void Delete(Course entity)
        {
            _courseDal.Remove(entity);
        }

        public List<Course> GetAll()
        {
            return _courseDal;
        }

        public Course GetById(int id)
        {
            return _courseDal.Where(c => c.Id == id).FirstOrDefault();
        }

        public void Update(Course entity)
        {
            var upDateCourse = _courseDal.FirstOrDefault(c => c.Id == entity.Id);

            if (upDateCourse != null)
            {
                upDateCourse.CourseName = entity.CourseName;
                upDateCourse.CourseDescription = entity.CourseDescription;
                upDateCourse.CourseInstructorName = entity.CourseInstructorName;
            }
        }
    }
}