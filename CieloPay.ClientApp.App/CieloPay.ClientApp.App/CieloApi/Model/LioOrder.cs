using System;
using System.Collections.Generic;

namespace CieloPay.ClientApp.App.CieloApi.Model
{
    public class LioOrder
    {
        public string Status { get; set; }
        public List<LioOrderItem> Items { get; set; }
        public int UserId { get; set; }
        public string LioResponseId { get; set; }
        public Guid PaymentId { get; set; }
    }

    public class LioOrderItem
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Unit_Price { get; set; }
        public int Quantity { get; set; }
    }
}
