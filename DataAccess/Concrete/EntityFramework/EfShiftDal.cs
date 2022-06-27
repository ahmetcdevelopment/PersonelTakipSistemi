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
    public class EfShiftDal : IShiftDal
    {
        public void Add(Shift entity)
        {
            using (PDSKContext context = new PDSKContext())
            {
                var addedShift = context.Entry(entity);
                addedShift.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Shift entity)
        {
            using (PDSKContext context = new PDSKContext())
            {
                var deletedShift = context.Entry(entity);
                deletedShift.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (PDSKContext context = new PDSKContext())
            {
                var removedShift = context.Entry(id);
                removedShift.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Shift> GetAll(Expression<Func<Shift, bool>> filter = null)
        {
            using (PDSKContext context = new PDSKContext())
            {
                return filter==null ? context.Set<Shift>().ToList() :
                    context.Set<Shift>().Where(filter).ToList();
            }
        }

        public Shift GetT(Expression<Func<Shift, bool>> filter = null)
        {
            using (PDSKContext context = new PDSKContext())
            {
                return context.Set<Shift>().SingleOrDefault(filter);
            }
        }

        public void Update(Shift entity)
        {
            using (PDSKContext context = new PDSKContext())
            {
                var updatedShift = context.Entry(entity);
                updatedShift.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
