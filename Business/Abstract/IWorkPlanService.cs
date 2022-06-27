using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWorkPlanService
    {
        List<WorkPlan> GetAll();
        void Add(WorkPlan shift);
        void Update(WorkPlan shift);
        void Delete(WorkPlan shift);
    }
}
