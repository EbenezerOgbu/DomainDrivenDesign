using System;

namespace DomainDrivenDesign.Model.Orders.States
{
    public class SubmittedOrderState : OrderState
    {
        public override OrderStatus Status
        {
            get { return OrderStatus.Submitted; }
        }

        public override bool CanAddProduct()
        {
            return false;
        }

        public override void Submit(Order order)
        {
            throw new InvalidOperationException("You cannot submit this order as it has already been submitted.");
        }
    }

}
