﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class Student
    {
        public string ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Group[] Groups{ get; set; }
    }
}
