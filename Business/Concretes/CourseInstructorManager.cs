using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CourseInstructorManager : ICourseInstructorService
    {
        ICourseInstructorDal _courseInstructorDal;
        public CourseInstructorManager(ICourseInstructorDal courseInstructorDal)
        {
            _courseInstructorDal = courseInstructorDal;
        }

        public IResult Add(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Add(courseInstructor);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Delete(courseInstructor);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IResult Update(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Update(courseInstructor);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        public IDataResult<List<CourseInstructor>> GetAll()
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInstructorDal.GetAll(), Messages.CategoriesListed);
        }

        public IDataResult<CourseInstructor> GetById(int id)
        {
            return new SuccessDataResult<CourseInstructor>(_courseInstructorDal.Get(p => p.Id == id));
        }
    }

}
