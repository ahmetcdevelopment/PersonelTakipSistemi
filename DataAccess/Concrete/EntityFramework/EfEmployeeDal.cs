using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : IEmployeeDal
    {
        public void Add(Employee entity)
        {
            using (PDSKContext context = new PDSKContext())
            {
                var addedEmployee = context.Entry(entity);
                addedEmployee.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Employee entity)
        {
            using (PDSKContext context = new PDSKContext())
            {
                var deletedEmployee = context.Entry(entity);
                deletedEmployee.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (PDSKContext context = new PDSKContext())
            {
                var deletedEmployee = context.Entry(id);
                deletedEmployee.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Employee> GetAll(Expression<Func<Employee, bool>> filter = null)
        {
            using (PDSKContext context = new PDSKContext())
            {
                return filter==null?context.Set<Employee>().ToList() :
                    context.Set<Employee>().Where(filter).ToList();
            }
        }

        public Employee GetT(Expression<Func<Employee, bool>> filter = null)
        {
            using (PDSKContext context = new PDSKContext())
            {
                return context.Set<Employee>().FirstOrDefault(filter);
            }
        }

        public void Update(Employee entity)
        {
            using (PDSKContext context = new PDSKContext())
            {
                var updatedEmployee = context.Entry(entity);
                updatedEmployee.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
