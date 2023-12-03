using Business.Abstracts;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Entities.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
	public class CourseManager : ICourseService
	{
		ICourseDal _courseDal;
		ICategoryService _categoryService;
		public CourseManager(ICourseDal courseDal, ICategoryService categoryService)
		{
			_courseDal = courseDal;
			_categoryService = categoryService;
		}

		[SecuredOperation("product.add,admin")]
		[ValidationAspect(typeof(CourseValidator))]
		public IResult Add(Course course)
		{
			var result = BusinessRules.Run(CheckIfCourseNameExists(course.Name), CheckIfProductCountOfCategoryCorrect(course.CategoryId));
			if (result != null)
			{
				return result;
			}
			_courseDal.Add(course);
			return new SuccessResult(Messages.CategoryAdded);
		}

		public IResult Delete(Course course)
		{
			_courseDal.Delete(course);
			return new SuccessResult(Messages.CategoryDeleted);
		}

		public IResult Update(Course course)
		{
			_courseDal.Update(course);
			return new SuccessResult(Messages.CategoryUpdated);
		}

		public IDataResult<List<Course>> GetAll()
		{
			return new SuccessDataResult<List<Course>>(_courseDal.GetAll(), Messages.CategoriesListed);
		}

		public IDataResult<Course> GetById(int id)
		{
			return new SuccessDataResult<Course>(_courseDal.Get(p => p.Id == id));
		}

		public IDataResult<List<CourseDetail>>  GetDetails()
		{
			if (DateTime.Now.Hour == 17)
			{
				return new SuccessDataResult<List<CourseDetail>>(_courseDal.GetDetails());
			}
			return new ErrorDataResult<List<CourseDetail>>(Messages.ErrorMessage);
		}

		public IDataResult<List<Course>> GetAllByUnitPrice(double minValue, double maxValue)
		{
			return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p => p.Price>minValue &&p.Price<maxValue));
		}

		public IDataResult<List<Course>> GetAllByCategoryId(int categoryId)
		{
			return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p => p.CategoryId==categoryId));
		}

		private IResult CheckIfCourseNameExists(string courseName)
		{
			var result = _courseDal.GetAll(p => p.Name == courseName).Any();
			if (result)
			{
				return new ErrorResult("course already added!");
			}
			return new SuccessResult();
		}

		private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
		{
			var result = _courseDal.GetAll(p => p.CategoryId == categoryId).Count;
			if (result >= 15)
			{
				return new ErrorResult();
			}
			return new SuccessResult();
		}
    }
}
