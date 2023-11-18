using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseInstructorService
    {
        IResult Add(CourseInstructor courseInstructor);
        IResult Delete(CourseInstructor courseInstructor);
        IResult Update(CourseInstructor courseInstructor);
        IDataResult<List<CourseInstructor>> GetAll();
        IDataResult<CourseInstructor> GetById(int id);
    }
}
