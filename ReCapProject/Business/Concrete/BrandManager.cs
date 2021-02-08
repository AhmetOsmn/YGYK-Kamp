using ReCapProject.Business.Abstract;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Concrete
{
    public class BrandManager : ICarRentalService<Brand>
    {
        ICarRentalDal<Brand> _carRentalDal;

        public BrandManager(ICarRentalDal<Brand> carRentalDal)
        {
            _carRentalDal = carRentalDal;
        }
        public List<Brand> GetAll()
        {
            return _carRentalDal.GetAll();
        }
    }
}
