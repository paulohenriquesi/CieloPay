using System;
using Xamarin.Forms;

namespace PedidoFacin.Drugstore.App.ViewModel
{
    public class FoodMenuItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
