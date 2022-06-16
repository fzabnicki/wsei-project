using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Interfaces
{
    public interface ILessonLogic
    {
        Task<List<Lesson>> GetLessonsByGroup(Group[] groups);
    }
}
