﻿using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProject.Models
{
    public class Teacher
    {

        //the following fields define a teacher
        public int TeacherId;
         public double salary;
          public string employeenumber;
            public string Hiredate;
            public string TeacherFname; 
            public string TeacherLname;

        //parameter-less constructor function
        public Teacher() { }
    }
}

