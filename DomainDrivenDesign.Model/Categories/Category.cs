using System;
using DomainDrivenDesign.Infrastructure.Domain;

namespace DomainDrivenDesign.Model.Categories
{
    public class Category : EntityBase<int>, IAggregateRoot
    {
        public string Name { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
