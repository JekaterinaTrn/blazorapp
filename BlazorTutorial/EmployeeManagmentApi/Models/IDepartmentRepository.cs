﻿using EmployeeManagmentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagmentApi.Models
{
    public interface IDepartmentRepository
    {
        

        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
    }
}
