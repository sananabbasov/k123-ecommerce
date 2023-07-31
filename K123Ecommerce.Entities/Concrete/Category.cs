using System;
using K123Ecommerce.Core.Entities.Abstract;

namespace K123Ecommerce.Entities.Concrete
{
    public class Category : BaseEntity, IEntity
    {
        public string CategoryName { get; set; }
        public string PhotoUrl { get; set; }
    }
}

