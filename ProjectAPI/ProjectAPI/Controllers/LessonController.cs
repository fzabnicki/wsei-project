using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Interfaces;
using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("lesson")]
    public class LessonController : Controller
    {
        private readonly ILessonLogic _lessonLogic;
        public LessonController(ILessonLogic lessonLogic)
        {
            _lessonLogic = lessonLogic;
        }
        [HttpGet]
        public async Task<List<Lesson>> GeGetLessonsByGroup(Group[] groups)
        {
            return await _lessonLogic.GetLessonsByGroup(groups);
        }
    }
}
