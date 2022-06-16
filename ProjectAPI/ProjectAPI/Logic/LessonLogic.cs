using ProjectAPI.Interfaces;
using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Logic
{
    public class LessonLogic : ILessonLogic
    {
        private readonly DataContext _context;
        public LessonLogic(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Lesson>> GetLessonsByGroup(Group[] groups)
        {
            List<Lesson> result = new List<Lesson>();

            if(groups == null && groups.Length == 0 )
                throw new ArgumentNullException("No group provided");

            foreach (Group item in groups)
            {
                result.Concat(_context.Lessons.Where(lesson => lesson.Group.ID == item.ID).ToList());
            }

            return result;
        }
    }
}
