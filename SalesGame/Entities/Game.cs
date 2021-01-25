using SalesGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesGame.Entities
{
    public class Game : IEntity
    {
        
        public double UnitPrice { get; set; }
        public string DateOfDevelopment { get; set; }
    }
}
