using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WorkPlanManager : IWorkPlanService
    {
        IWorkPlanDal _workPlanDal;
        public WorkPlanManager(IWorkPlanDal workPlanDal)
        {
            _workPlanDal = workPlanDal;
        }
        public void Add(WorkPlan shift)
        {
            _workPlanDal.Add(shift);
        }

        public void Delete(WorkPlan shift)
        {
            _workPlanDal.Delete(shift);
        }

        public List<WorkPlan> GetAll()
        {
            return _workPlanDal.GetAll();
        }

        public void Update(WorkPlan shift)
        {
            _workPlanDal.Update(shift);
        }
    }
}
