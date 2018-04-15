using System.Collections.Generic;
using DomainDrivenDesign.Infrastructure.Domain.Events;

namespace Lotiza.Infrastructure.Domain.Events
{
    public class NinjectDomainEventHandlerFactory : IDomainEventHandlerFactory
    {
        public IEnumerable<IDomainEventHandler<T>> GetDomainEventHandlersFor<T>(T domainEvent) where T : IDomainEvent
       {
            return new List<IDomainEventHandler<T>>(); // Use Service Locator.
        }
    }

}
