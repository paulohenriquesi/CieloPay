using System;

namespace PedidoFacin.Drugstore.App.ViewModel
{
    public class FoodMenuItemViewModel
    {
        public Guid Id { get; set; }
        public DeliveryTimeRangeViewModel DeliveryTime { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    public class DeliveryTimeRangeViewModel
    {
        public TimeUnitEnum TimeUnit { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
    }

    public enum TimeUnitEnum
    {
        Minute,
        Hour,
        Day
    }
}
