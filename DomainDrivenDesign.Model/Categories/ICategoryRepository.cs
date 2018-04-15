using DomainDrivenDesign.Infrastructure.Domain;

namespace DomainDrivenDesign.Model.Categories
{
    public interface ICategoryRepository : IReadOnlyRepository<Category, int>
    {
    }
}
