using Core.Utilities.Results;
using Entities.Concretes;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        IResult Add(Course course);
        IResult Delete(Course course);
        IResult Update(Course course);
        IDataResult<List<Course>> GetAll();
        IDataResult<List<Course>> GetAllByUnitPrice(double minValue,double maxValue);
        IDataResult<List<Course>> GetAllByCategoryId(int categoryId);
        IDataResult<List<CourseDetail>> GetDetails();
        IDataResult<Course> GetById(int id);
    }
}
