using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class Lesson
    {
        public string Name { get; set; }
        public Professor Professor{ get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public Group Group { get; set; }
    }
}
