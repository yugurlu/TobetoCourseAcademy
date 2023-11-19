using System;
using Autofac;
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
	public class AutofacBusinessModule : Module
	{
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourseManager>().As<ICourseService>().SingleInstance();
            builder.RegisterType<EfCourseDal>().As<ICourseDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<InstructorManager>().As<IInstructorService>().SingleInstance();
            builder.RegisterType<EfInstructorDal>().As<IInstructorDal>().SingleInstance();

            builder.RegisterType<CourseInstructorManager>().As<ICourseInstructorService>().SingleInstance();
            builder.RegisterType<EfCourseInstructorDal>().As<ICourseInstructorDal>().SingleInstance();
        }
    }
}

