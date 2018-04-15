using System;
using DomainDrivenDesign.Infrastructure.Domain;

namespace DomainDrivenDesign.Model.Basket
{
    public interface IBasketRepository : IRepository<Basket, Guid>
    {
    }
}
