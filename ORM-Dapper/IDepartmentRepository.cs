﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace ORM_Dapper
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> GetAllDepartments();

        public void InsertDepartment(string newDepartmentName)
        {
           
        }
    }
}