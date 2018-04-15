using DomainDrivenDesign.Infrastructure.Domain;

namespace DomainDrivenDesign.Model.Orders
{
    public interface IOrderRepository : IRepository<Order, int>
    {
    }
}
