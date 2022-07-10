﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalTracking.Models
{
    class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
        public string PositionName { get; set; }
        public string DepartmentName { get; set; }
        public int Salary { get; set; }
        public bool isAdmin { get; set; }
        public DateTime BirthDay { get; set; }
        public string Adress { get; set; }
        public string Password { get; set; }

    }
}