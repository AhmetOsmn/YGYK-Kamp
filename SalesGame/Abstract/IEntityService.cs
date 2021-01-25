using SalesGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesGame.Abstract
{
    public interface IEntityService
    {
        void Add(IEntity entity, List<IEntity> entities);
        
        void Delete(IEntity entity, List<IEntity> entities);
        void Update(IEntity entity, string N);
        
        void Buy(IEntity player, IEntity game);
        void Return(IEntity player, IEntity game);
        void Show(List<IEntity> entities);
       
    }
}
