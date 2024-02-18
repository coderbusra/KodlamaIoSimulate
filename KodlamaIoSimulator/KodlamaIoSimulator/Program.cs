using BusinessLayer;
using BusinessLayer.Concrete;
using DataAccsess;
using DataAccsess.Concretes;
using EntityLayer;
using EntityLayer.Concrete;

CategoryManager categoryManager = new CategoryManager(new CategoryDal());
CourseManager courseManager = new CourseManager(new CourseDal());
InstructorManager instructorManager = new InstructorManager(new InstructorDal());

List<Course> _courseDal = courseManager.TGetAll();

Console.WriteLine("  ------- KODLAMA İ.O --------  \n");

//Course CRUD
Console.WriteLine("\n ***** Kurslar ****** \n");

ListCourses(_courseDal);

Console.WriteLine("\n -- Kurs Ekleme -- \n");
Course course4 = new Course
{
    Id = 4,
    CourseName = "Yazılım Geliştirici Kampı",
    CourseDescription = "Java",
    CourseInstructorName = "Engin Demirog"
};

Course course5 = new Course
{
    Id = 5,
    CourseName = "Yazılım Geliştrici Kampı ",
    CourseDescription = " JavaScript ",
    CourseInstructorName = "Engin Demirog"
};

courseManager.TAdd(course4);
courseManager.TAdd(course5);

ListCourses(_courseDal);

Console.WriteLine("\n -- Kurs Silme -- \n");

courseManager.TDelete(course4);

ListCourses(_courseDal);

Console.WriteLine("\n -- Kurs Güncelleme -- \n");

course5.Id = 4;
courseManager.TUpdate(course5);

ListCourses(_courseDal);

//Category CRUD
Console.WriteLine("\n \n ***** Kategoriler ***** \n");

List<Category> _categoryDal = categoryManager.TGetAll();

ListCategories(_categoryDal);

Console.WriteLine("\n -- Kategori ekleme -- \n");

Category category3 = new Category
{
    Id = 3,
    CategoryName = "Yapay Zeka",
};

Category category4 = new Category
{
    Id = 4,
    CategoryName = "Veri Tabanı"
};

categoryManager.TAdd(category3);
categoryManager.TAdd(category4);

ListCategories(_categoryDal);

Console.WriteLine("\n -- Kurs Silme -- \n");

categoryManager.TDelete(category3);

ListCategories(_categoryDal);

Console.WriteLine("\n -- Kurs Güncelleme -- \n");

category4.Id = 3;
categoryManager.TUpdate(category4);

ListCategories(_categoryDal);

// Instructor CRUD
Console.WriteLine("\n ***** Eğitmenler ****** \n");

List<Instructor> _instructorDal = instructorManager.TGetAll();

ListInstroctors(_instructorDal);

Console.WriteLine("\n -- Eğitmen Ekleme -- \n");

Instructor instructor3 = new Instructor
{
    Id = 3,
    InstructorFirstName = "Emre",
    InstructorLastName = "Altunbilek",
    InstructorAbout = "Yazılımcı"
};

Instructor instructor4 = new Instructor
{
    Id = 4,
    InstructorFirstName = "Mustafa Murat",
    InstructorLastName = "Coşkun",
    InstructorAbout = "Yazılımcı"
};

instructorManager.TAdd(instructor3);
instructorManager.TAdd(instructor4);

ListInstroctors(_instructorDal);

Console.WriteLine("\n -- Eğitmen Silme -- \n");

instructorManager.TDelete(instructor3);

ListInstroctors(_instructorDal);

Console.WriteLine("\n -- Eğitmen Güncelleme -- \n");

instructor4.Id = 3;
instructorManager.TUpdate(instructor4);

ListInstroctors(_instructorDal);

static void ListInstroctors(List<Instructor> _instructorDal)
{
    for (int i = 0; i < _instructorDal.Count; i++)
    {
        Console.WriteLine(_instructorDal[i].Id + " - " + _instructorDal[i].InstructorFirstName + " - " + _instructorDal[i].InstructorLastName + " - " + _instructorDal[i].InstructorAbout);
    }
}

static void ListCategories(List<Category> _categoryDal)
{
    for (int i = 0; i < _categoryDal.Count; i++)
    {
        Console.WriteLine(_categoryDal[i].Id + " - " + _categoryDal[i].CategoryName);
    }
}

static void ListCourses(List<Course> _courseDal)
{
    for (int i = 0; i < _courseDal.Count; i++)
    {
        Console.WriteLine(_courseDal[i].Id + " - " + _courseDal[i].CourseName + " - " + _courseDal[i].CourseDescription);
    }
}