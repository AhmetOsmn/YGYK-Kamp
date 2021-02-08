using ReCapProject.Business.Abstract;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Concrete
{
    public class CarManager : ICarRentalService<Car>
    {
        ICarRentalDal<Car> _carRentalDal;
        public CarManager(ICarRentalDal<Car> carRentalDal)
        {
            _carRentalDal = carRentalDal;
        }
        public List<Car> GetAll()
        {
            return _carRentalDal.GetAll();
        }
    }
}
