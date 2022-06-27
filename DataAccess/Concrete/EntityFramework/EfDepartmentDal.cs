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
    public class EfDepartmentDal : IDepartmentDal
    {
        public void Add(Department entity)
        {
            using (PDSKContext context = new PDSKContext())
            {
                var addedDepartment = context.Entry(entity);
                addedDepartment.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Department entity)
        {
            using (PDSKContext context = new PDSKContext())
            {
                var deletedDepartment = context.Entry(entity);
                deletedDepartment.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (PDSKContext context=new PDSKContext())
            {
                var deletedDepartment = context.Entry(id);
                deletedDepartment.State= EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Department> GetAll(Expression<Func<Department, bool>> filter = null)
        {
            using (PDSKContext context = new PDSKContext())
            {
                return filter==null ? context.Set<Department>().ToList() :
                    context.Set<Department>().Where(filter).ToList();
            }
        }

        public Department GetT(Expression<Func<Department, bool>> filter = null)
        {
            using (PDSKContext context = new PDSKContext())
            {
                return context.Set<Department>().SingleOrDefault(filter);
            }
        }

        public void Update(Department entity)
        {
            using (PDSKContext context = new PDSKContext())
            {
                var updatedDepartment = context.Entry(entity);
                updatedDepartment.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
