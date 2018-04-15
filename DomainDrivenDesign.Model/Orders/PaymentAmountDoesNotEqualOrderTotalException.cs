using System;

namespace DomainDrivenDesign.Model.Orders
{
    public class PaymentAmountDoesNotEqualOrderTotalException : Exception
    {
        public PaymentAmountDoesNotEqualOrderTotalException(string message)
            : base(message)
        {
        }
    }

}
