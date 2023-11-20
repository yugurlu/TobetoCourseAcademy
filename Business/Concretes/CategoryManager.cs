using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Category category)
        {
           _categoryDal.Delete(category);
           return new SuccessResult(Messages.CategoryDeleted);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(),Messages.CategoriesListed);
        }

        public IDataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p => p.Id == id));
        }

      
    }
}
