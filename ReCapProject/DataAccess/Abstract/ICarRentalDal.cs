﻿using ReCapProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.DataAccess.Abstract
{
    public interface ICarRentalDal<T>
    {
        T GetById(int id);
        List<T> GetAll();
        void Add(T t);
        void Update(T t);
        void Delete(T t);
    }
}
