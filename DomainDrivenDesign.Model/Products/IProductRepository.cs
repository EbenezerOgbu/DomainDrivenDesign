using DomainDrivenDesign.Infrastructure.Domain;

namespace DomainDrivenDesign.Model.Products
{
    public interface IProductRepository : IReadOnlyRepository<Product, int>
    {
    }
}
