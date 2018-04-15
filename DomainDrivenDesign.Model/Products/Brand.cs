using System;
using DomainDrivenDesign.Infrastructure.Domain;

namespace DomainDrivenDesign.Model.Products
{
    public class Brand : EntityBase<int>
    {
        public string Name { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
