using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IShiftService
    {
        List<Shift> GetAll();
        void Add(Shift shift);
        void Update(Shift shift);
        void Delete(int id);
    }
}
