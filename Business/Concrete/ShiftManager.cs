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
    public class ShiftManager : IShiftService
    {
        IShiftDal _shiftDal;

        public ShiftManager()
        {
            _shiftDal = new EfShiftDal();
        }

        public ShiftManager(IShiftDal shiftDal)
        {
            _shiftDal = shiftDal;
        }
        public void Add(Shift shift)
        {
            _shiftDal.Add(shift);
        }

        //public void Delete(Shift shift)
        //{
        //    _shiftDal?.Delete(shift);
        //}

        public void Delete(int id)
        {
            _shiftDal.Delete(id);
        }

        public List<Shift> GetAll()
        {
            return _shiftDal.GetAll();
        }

        public void Update(Shift shift)
        {
            _shiftDal.Update(shift);
        }
    }
}
