using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public EmployeeManager()
        {
            _employeeDal = new EfEmployeeDal();
        }

        public void Add(Employee employee)
        {
            _employeeDal.Add(employee);
        }

        public void Delete(int id)
        {
            _employeeDal.Delete(id);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();   
        }

        public void Update(Employee employee)
        {
            _employeeDal.Update(employee);
        }
    }
}
