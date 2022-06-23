using System;
using Volo.Abp.Domain.Entities;

namespace AbpProject.Products
{
    public class Product : Entity<Guid>
    {
        public Product(Guid id, string name, ProductType type, float price, DateTime createdDate) : base(id)
        {
        }

        public string Name { get; set; }
        public ProductType Type { get; set; }
        public float Price { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
