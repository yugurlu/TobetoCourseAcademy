using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
    public class InstructorManager:IInstructorService
    {
        IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public IResult Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
            return new SuccessResult(Messages.CategoryDeleted);
        }
        public IResult Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        public IDataResult<List<Instructor>> GetAll()
        {
            return new SuccessDataResult<List<Instructor>>(_instructorDal.GetAll(), Messages.CategoriesListed);
        }

        public IDataResult<Instructor> GetById(int id)
        {
            return new SuccessDataResult<Instructor>(_instructorDal.Get(p => p.Id == id));
        }


    }

}
