using System;

namespace DomainDrivenDesign.Model.Orders
{
    public class OrderAlreadyPaidForException : Exception
    {
        public OrderAlreadyPaidForException(string message) : base(message)
        {
        }
    }
}
