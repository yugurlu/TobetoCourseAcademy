using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetInstructorDal
    {
        public void Add(Instructor ınstructor)
        {
            Console.WriteLine("Added to db with Ado.Net");
        }
    }
}
