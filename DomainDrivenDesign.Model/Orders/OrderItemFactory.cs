using DomainDrivenDesign.Model.Products;

namespace DomainDrivenDesign.Model.Orders
{
    public static class OrderItemFactory
    {
        public static OrderItem CreateItemFor(Product product, Order order, int qty)
        {
            return new OrderItem(product, order, qty);
        }
    }

}
