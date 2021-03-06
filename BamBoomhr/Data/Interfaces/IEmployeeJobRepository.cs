﻿using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IEmployeeJobRepository
    {

        IEnumerable<EmployeeJob> EmployeeJobs { get; set; }
        IEnumerable<EmployeeJob> PreferredEmployeeJobs { get; set; }
        EmployeeJob GetEmployeeJobById(int EmployeeJobId);
    }
}
