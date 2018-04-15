using System;
using System.Collections.Generic;
using System.Text;

namespace DomainDrivenDesign.Infrastructure.Domain
{
    public interface IReadOnlyRepository<T, TId> where T : IAggregateRoot
    {
        T FindBy(TId id);
        IEnumerable<T> FindAll();
    }
}
