﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    public class EmployeeDto
    {
        public Guid guid { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
    }
}
