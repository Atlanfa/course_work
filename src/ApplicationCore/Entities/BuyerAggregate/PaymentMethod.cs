﻿namespace eshop.ApplicationCore.Entities.BuyerAggregate
{
    public class PaymentMethod : BaseEntity
    {
        public string Alias { get; private set; }
        public string CardId { get; private set; }
        public string Last4 { get; private set; }
    }
}
