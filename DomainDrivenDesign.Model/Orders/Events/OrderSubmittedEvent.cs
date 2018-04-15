
using DomainDrivenDesign.Infrastructure.Domain.Events;

namespace DomainDrivenDesign.Model.Orders.Events
{
    public class OrderSubmittedEvent : IDomainEvent
    {
        public Order Order { get; set; }
    }

}
