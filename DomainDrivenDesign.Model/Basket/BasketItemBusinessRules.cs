﻿using DomainDrivenDesign.Infrastructure.Domain;

namespace DomainDrivenDesign.Model.Basket
{
    public class BasketItemBusinessRules
    {
        public static readonly BusinessRule BasketRequired = new BusinessRule("Basket", "A basket item must be related to a basket.");
        public static readonly BusinessRule ProductRequired = new BusinessRule("Product", "A basket item must be related to a product.");
        public static readonly BusinessRule QtyInvalid = new BusinessRule("Qty", "The quantity of a basket item cannot be negative.");
    }
}
