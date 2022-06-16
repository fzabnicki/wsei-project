using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Interfaces
{
    public interface IStudentLogic
    {
        Task<Student> GetStudent(string Id);
    }
}
