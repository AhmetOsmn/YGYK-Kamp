using SalesGame.Abstract;
using SalesGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesGame.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(IEntity entity)
        {
            if (entity.Name == "AHMET SEZGIN")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
