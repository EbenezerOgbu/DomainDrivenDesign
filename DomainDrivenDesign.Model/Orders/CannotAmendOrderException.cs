using System;

namespace DomainDrivenDesign.Model.Orders
{
    public class CannotAmendOrderException : Exception
    {
        public CannotAmendOrderException(string message)
            : base(message)
        {

        }
    }
}
