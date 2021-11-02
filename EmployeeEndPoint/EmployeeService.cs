using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEndPointProject
{
    public class EmployeeService : IEmployeeService
    {
        public string ShowEmployee(Employee e)
        {
            return "We have a new employee:" +
                $" {e.FirstName}  {e.LastName}";
        }
    }
}
