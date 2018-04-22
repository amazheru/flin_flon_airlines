/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlinFlon
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World");
            try
            {
                EmployeeDAO emp = new EmployeeDAO();

                foreach (Employee temp in emp.Employees)
                {
                    Console.WriteLine(temp.Name);
                }

                
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
            Application.Run(new FrmWelcome());

            Console.Read();
        }
    }
}*/
