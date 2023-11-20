using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;


#region Course
            Course course1 = new Course
            {
                CategoryId = 1,
                Description = "test",
                ImageUrl = "test",
                Name = "#",
                Price = 0,
            };
            Course course2 = new Course
            {
                CategoryId = 1,
                Description = "test",
                ImageUrl = "test",
                Name = "JAVA",
                Price = 35
            };
            Course course3 = new Course
            {
                Id = 3,
                CategoryId = 2,
                Description = "test",
                ImageUrl = "test",
                Name = "JavaScript",
                Price = 35
            };

            #endregion

#region Category
            Category category1 = new Category { Name = "Backend" };
            Category category2 = new Category { Name = "FrontEnd" };

            #endregion

#region Instructor
            Instructor instructor1 = new Instructor {FirstName = "Kadir ", LastName = "Avşar" };
            Instructor instructor2 = new Instructor {FirstName = "Metin ", LastName = "Koyuncu" };
            Instructor instructor3 = new Instructor { FirstName = "Özkan ", LastName = "Akkaya" };
            Instructor instructor4 = new Instructor {FirstName = "Burak ", LastName = "Tan" };
            #endregion

//Kurs Ve Eğitmen İlişkileri

CourseManager courseManager = new CourseManager(new EfCourseDal());

var value = courseManager.Add(course1);
Console.WriteLine(value.Message);
//foreach (var item in value.Data)
//{
//    Console.WriteLine(item.Name + " " + item.Description);
//}

Console.ReadKey();