using ReCapProject.Business.Abstract;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Concrete
{
    public class ColorManager : ICarRentalService<Color>
    {
        ICarRentalDal<Color> _carRentalDal;

        public ColorManager(ICarRentalDal<Color> carRentalDal)
        {
            _carRentalDal = carRentalDal;
        }
        public List<Color> GetAll()
        {
            return _carRentalDal.GetAll();
        }
    }
}
