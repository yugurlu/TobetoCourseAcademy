using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public Category? Category { get; set; }
        public CourseInstructor[]? CourseInstructor { get; set; }

    }
}
