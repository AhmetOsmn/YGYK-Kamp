using SalesGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesGame.Entities
{
    public class Player : IEntity
    {
        public int CustomerId { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
