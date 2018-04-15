using DomainDrivenDesign.Model.Products;

namespace DomainDrivenDesign.Model.Basket
{
    public static class BasketItemFactory
    {
        public static BasketItem CreateItemFor(Product product, Basket basket)
        {
            return new BasketItem(product, basket, 1);
        }
    }
}
