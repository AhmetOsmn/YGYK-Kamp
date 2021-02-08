using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
    public interface ICarRentalService<T>
    {
        List<T> GetAll();
    }
}
