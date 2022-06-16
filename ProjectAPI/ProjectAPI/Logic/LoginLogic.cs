using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Interfaces;
using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Logic
{
    public class LoginLogic : ILoginLogic
    {
        private readonly DataContext _context;
        public LoginLogic(DataContext context)
        {
            _context = context;
        }

        public async Task Login(string login, string password)
        {
            var student = await _context.Students.FirstOrDefaultAsync(student => student.Email == login.ToLower()
                                                                              && student.Password == password);
        }
    }
}
