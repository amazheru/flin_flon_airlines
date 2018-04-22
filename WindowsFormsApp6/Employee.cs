using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace FlinFlon
{
    [Table( Name = "Employees")]
    public class Employee
    {
        
        [Column] public string Name { get; set; }
       
        [Column(Name = "EmpID", IsPrimaryKey = true, IsDbGenerated = true)] public int ID { get; set; }      

        [Column] public string Password { get; set; }
        
    }
 
}
