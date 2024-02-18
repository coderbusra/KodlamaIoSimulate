using DataAccsessLayer.Abstracts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categoryDal;
        public CategoryDal()
        {
            List<Category> category1 = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    CategoryName = "Tümü",
                },

                new Category
                {
                    Id = 2,
                    CategoryName = "Programlama",
                }
            };
            _categoryDal = category1; 
        }
        public void Add(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDal.Remove(entity);
        }

        public List<Category> GetAll()
        {
            return _categoryDal;
        }

        public Category GetById(int id)
        {
            return _categoryDal.Where(c => c.Id == id).FirstOrDefault();
        }

        public void Update(Category entity)
        {
            var categoryUpdate = _categoryDal.FirstOrDefault(c=>c.Id== entity.Id);
            if (categoryUpdate != null)
            {
                categoryUpdate.CategoryName= entity.CategoryName;
            }
            else
            {
                Console.WriteLine("Kategori bulunamadı" + entity.Id);
            }
        }
    }
}
