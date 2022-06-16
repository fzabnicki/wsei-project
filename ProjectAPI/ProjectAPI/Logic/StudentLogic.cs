using Microsoft.EntityFrameworkCore;
using ProjectAPI.Interfaces;
using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Logic
{
    public class StudentLogic : IStudentLogic
    {
        private readonly DataContext _context;
        public StudentLogic(DataContext context)
        {
            _context = context;
        }

        public async Task<Student> GetStudent(string Id)
        {
            return await _context.Students.FirstOrDefaultAsync(student => student.ID == Id);
        }
    }
}
