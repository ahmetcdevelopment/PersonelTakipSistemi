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
    public class EfWorkPlanDal : IWorkPlanDal
    {
        public void Add(WorkPlan entity)
        {
            using (PDSKContext context = new PDSKContext())
            {
                var addedWorkPlan = context.Entry(entity);
                addedWorkPlan.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(WorkPlan entity)
        {
            using (PDSKContext context = new PDSKContext())
            {
                var deletedWorkPlan = context.Entry(entity);
                deletedWorkPlan.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<WorkPlan> GetAll(Expression<Func<WorkPlan, bool>> filter = null)
        {
            using (PDSKContext context = new PDSKContext())
            {
                return filter==null ? context.Set<WorkPlan>().ToList() :
                    context.Set<WorkPlan>().Where(filter).ToList();
            }
        }

        public WorkPlan GetT(Expression<Func<WorkPlan, bool>> filter = null)
        {
            using (PDSKContext context = new PDSKContext())
            {
                return context.Set<WorkPlan>().SingleOrDefault(filter);
            }
        }

        public void Update(WorkPlan entity)
        {
            using (PDSKContext context = new PDSKContext())
            {
                var updatedWorkPlan = context.Entry(entity);
                updatedWorkPlan.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
