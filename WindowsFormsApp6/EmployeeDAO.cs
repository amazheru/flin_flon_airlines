using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace FlinFlon
{
    [Database(Name = "EmployeeDAO")]
    public class EmployeeDAO : DataContext
    {
        public EmployeeDAO() : base("F:\\CSC330\\C#\\Project #2\\WindowsFormsApp6\\WindowsFormsApp6\\Database1.mdf")
        { }



        public Table<Employee> Employees;

        /*public Employee getNamePass(string name, string pass)
        {
            
        }*/
    }
}

