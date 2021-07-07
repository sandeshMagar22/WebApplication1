using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.DAL;

namespace WebApplication1.Repository
{
    interface IEmployeeRepository
    {

        IEnumerable<Employee> GetAll(); // Returns list of employees

        Employee GetById(int EmployeeID);  //single record

        void Insert(Employee employee); //Insert don't have any return data so,this is void

        void Update(Employee employee);

        void Delete(int EmployeeID);

        void Save();



        //update[name],[address],set value["sandesh"] where user.ID = 1  (used to in previous)





    }
}
