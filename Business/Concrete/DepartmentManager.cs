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
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;
        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }
        public DepartmentManager()
        {
            _departmentDal = new EfDepartmentDal();
        }
        public void Add(Department department)
        {
            _departmentDal.Add(department);
        }

        //public void Delete(Department department)
        //{
        //    _departmentDal.Delete(department);
        //}

        public void Delete(int id)
        {
            _departmentDal.Delete(id);
        }

        public List<Department> GetAll()
        {
            return _departmentDal.GetAll();
        }

        public void Update(Department department)
        {
            _departmentDal.Update(department);
        }
    }
}
