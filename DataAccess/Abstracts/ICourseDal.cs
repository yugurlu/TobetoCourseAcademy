using Core.DataAccess;
using Entities.Concretes;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICourseDal:IEntityRepository<Course>
    {
        List<CourseDetail> GetDetails();
    }
}
