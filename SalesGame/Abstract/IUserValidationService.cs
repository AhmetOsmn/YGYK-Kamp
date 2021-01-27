using SalesGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesGame.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(IEntity entity);
        
    }
}
