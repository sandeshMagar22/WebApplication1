using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Repository;

namespace WebApplication1.BLL
{
    public class EmployeeBLL
    {

        public readonly EmployeeRepository _objemployeeRepository;
        public EmployeeBLL()
        {
            _objemployeeRepository = new EmployeeRepository();

        }
        public IEnumerable<Employee> GetAllActiveEmployee()
        {
            var empData = _objemployeeRepository.GetAll();
            var ActiveEmployee = empData.Where(x => x.Gender == "Male");

            return ActiveEmployee.ToList();
        }
    }
}