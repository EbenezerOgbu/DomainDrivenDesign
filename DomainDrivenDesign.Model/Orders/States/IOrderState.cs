namespace DomainDrivenDesign.Model.Orders.States
{
    public interface IOrderState
    {
        int Id { get; set; }
        OrderStatus Status { get; }
        bool CanAddProduct();
        void Submit(Order order);
    }    

}
