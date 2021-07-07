using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.DAL;

namespace WebApplication1.Repository
{
    public class EmployeeRepository: IEmployeeRepository
    {


        private readonly ICMSDBContext _context;

        //Constructor
        public EmployeeRepository()
        {
            _context = new ICMSDBContext();
        }

        public EmployeeRepository(ICMSDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            // return database.table.tolist();
            return _context.Employees.ToList();
            // return _context.Employees.ToList();
        }


        public Employee GetById(int EmployeeID)
        {
            return _context.Employees.Find(EmployeeID);
        }
        public void Insert(Employee employee)
        {
            _context.Employees.Add(employee);
        }
        public void Update(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
        }
        public void Delete(int EmployeeID)
        {
            Employee employee = _context.Employees.Find(EmployeeID);
            _context.Employees.Remove(employee);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
