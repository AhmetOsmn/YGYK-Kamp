using ReCapProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Entities.Concrete
{
    public class Brand : IEntity
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
    }
}
