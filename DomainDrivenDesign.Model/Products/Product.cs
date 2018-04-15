using System;
using DomainDrivenDesign.Infrastructure.Domain;
using DomainDrivenDesign.Model.Categories;

namespace DomainDrivenDesign.Model.Products
{
    public class Product : EntityBase<int>, IAggregateRoot
    {      
        public string Description { get; set; }

        public string Name { get; set; }  

        public decimal Price { get; set; }

        public Brand Brand { get; set; }

        public ProductSize Size { get; set; }

        public ProductColor Color { get; set; }

        public Category Category { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
