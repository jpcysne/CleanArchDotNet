using CleanArch.Domain.Models;
using System.Collections.Generic;

namespace CleanArch.Domain.Interfases
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
